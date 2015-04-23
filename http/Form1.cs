using System;
using System.IO;
using System.Text;
using System.Threading;/* Thread */
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

using System.Windows.Forms;

namespace http
{
    public partial class Form1 : Form
    {
        private Thread Loading;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CharsetSet.SelectedIndex = 0;
        }

        private void SendRequest_Click(object sender, EventArgs e)
        {
            this.SendRequest.Enabled = false;

            Loading = new Thread(new ThreadStart(this.ShowLoadingUI));
            Loading.Start();

            new Thread(new ThreadStart(this.SendHttpRequestThread)).Start();
        }

        private void ShowLoadingUI() {
            this.ResponseData.Text = "Loading .";
            while (true) {
                this.ResponseData.Text += ".";
                Thread.Sleep(188);
            }
        }

        private void SendHttpRequestThread() {
            string ret = this.SendHttpRequest(this.RequestData.Text, this.CharsetSet.Text);
            Loading.Abort();
            this.ResponseData.Text = ret;
            this.SendRequest.Enabled = true;
        }

        private string SendHttpRequest(string RequestTxt, string charset)
        {
            if (RequestTxt.IndexOf("\r\n\r\n") == -1)
            {
                return "HTTP请求格式不正确!";
            }
            byte[] RequestBytes = Encoding.Default.GetBytes(RequestTxt);
            Regex Hosts = new Regex(@"^Host:\s?(.+?)[\r\n]?$", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            if (!Hosts.IsMatch(RequestTxt))
            {
                return "HTTP请求格式不正确!";
            }
            int iPort = 80;
            string Host = Hosts.Matches(RequestTxt)[0].Groups[1].Value;

            if (Host.IndexOf(":") != -1)
            {
                string[] t = Host.Split(':');
                Host = t[0];
                iPort = int.Parse(t[1]);
            }

            //IPAddress HostAddress = IPAddress.Parse(Host);
            IPAddress HostAddress = Dns.Resolve(Host).AddressList[0];
            IPEndPoint EPhost = new IPEndPoint(HostAddress, iPort);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            s.Connect(EPhost);

            s.Send(RequestBytes, RequestBytes.Length, SocketFlags.None);

            byte[] bytesReceived = new byte[2048];
            int bytes = 0;

            MemoryStream ms = new MemoryStream();

            do
            {
                bytes = s.Receive(bytesReceived);
                ms.Write(bytesReceived, 0, bytes);
                Thread.Sleep(188);
            } while (s.Available > 0);

            s.Close();

            return Encoding.GetEncoding(charset).GetString(ms.ToArray());

        }

        private void SelectAllText(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
