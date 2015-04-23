namespace http
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RequestData = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ResponseData = new System.Windows.Forms.TextBox();
			this.SendRequest = new System.Windows.Forms.Button();
			this.CharsetSet = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.RequestData);
			this.groupBox1.Location = new System.Drawing.Point(12, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(760, 253);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Request";
			// 
			// RequestData
			// 
			this.RequestData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RequestData.Location = new System.Drawing.Point(6, 20);
			this.RequestData.Multiline = true;
			this.RequestData.Name = "RequestData";
			this.RequestData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.RequestData.Size = new System.Drawing.Size(748, 227);
			this.RequestData.TabIndex = 0;
			this.RequestData.Text = "HEAD / HTTP/1.0\r\nHost: xqin.github.io\r\n\r\n";
			this.RequestData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectAllText);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.ResponseData);
			this.groupBox2.Location = new System.Drawing.Point(12, 297);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(760, 262);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Response";
			// 
			// ResponseData
			// 
			this.ResponseData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResponseData.Location = new System.Drawing.Point(6, 20);
			this.ResponseData.Multiline = true;
			this.ResponseData.Name = "ResponseData";
			this.ResponseData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ResponseData.Size = new System.Drawing.Size(748, 233);
			this.ResponseData.TabIndex = 1;
			this.ResponseData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectAllText);
			// 
			// SendRequest
			// 
			this.SendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SendRequest.Location = new System.Drawing.Point(622, 267);
			this.SendRequest.Name = "SendRequest";
			this.SendRequest.Size = new System.Drawing.Size(144, 33);
			this.SendRequest.TabIndex = 2;
			this.SendRequest.Text = "&Start";
			this.SendRequest.UseVisualStyleBackColor = true;
			this.SendRequest.Click += new System.EventHandler(this.SendRequest_Click);
			// 
			// CharsetSet
			// 
			this.CharsetSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CharsetSet.FormattingEnabled = true;
			this.CharsetSet.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.CharsetSet.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312"});
			this.CharsetSet.Location = new System.Drawing.Point(18, 274);
			this.CharsetSet.Name = "CharsetSet";
			this.CharsetSet.Size = new System.Drawing.Size(121, 20);
			this.CharsetSet.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(145, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(293, 36);
			this.label1.TabIndex = 4;
			this.label1.Text = "根据什么编码解服务器响应的HTTP内容.\r\n(如果服务器返回的内容是经过Gzip编码的,\r\n则可以将头部的Accept-Encoding: gzip这一行删除掉)" +
    "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 566);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CharsetSet);
			this.Controls.Add(this.SendRequest);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HTTP请求发送工具   --- 小秦制作";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SendRequest;
        private System.Windows.Forms.TextBox RequestData;
        private System.Windows.Forms.TextBox ResponseData;
        private System.Windows.Forms.ComboBox CharsetSet;
        private System.Windows.Forms.Label label1;
    }
}

