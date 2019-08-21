namespace SocketChattingProgram
{
    partial class ClientDevice
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
            this.ClientRename = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientPort = new System.Windows.Forms.TextBox();
            this.ClientIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CliSend = new System.Windows.Forms.Button();
            this.CliMessage = new System.Windows.Forms.TextBox();
            this.CliChatting = new System.Windows.Forms.RichTextBox();
            this.CliBack = new System.Windows.Forms.Button();
            this.CliEnter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientRename
            // 
            this.ClientRename.Location = new System.Drawing.Point(300, 96);
            this.ClientRename.Name = "ClientRename";
            this.ClientRename.Size = new System.Drawing.Size(75, 23);
            this.ClientRename.TabIndex = 6;
            this.ClientRename.Text = "변경";
            this.ClientRename.UseVisualStyleBackColor = true;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(112, 98);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(182, 21);
            this.ClientName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "채팅 참여 이름";
            // 
            // ClientPort
            // 
            this.ClientPort.Location = new System.Drawing.Point(80, 60);
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(276, 21);
            this.ClientPort.TabIndex = 3;
            // 
            // ClientIp
            // 
            this.ClientIp.Location = new System.Drawing.Point(80, 28);
            this.ClientIp.Name = "ClientIp";
            this.ClientIp.Size = new System.Drawing.Size(276, 21);
            this.ClientIp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "포트번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // CliSend
            // 
            this.CliSend.Location = new System.Drawing.Point(323, 527);
            this.CliSend.Name = "CliSend";
            this.CliSend.Size = new System.Drawing.Size(75, 23);
            this.CliSend.TabIndex = 12;
            this.CliSend.Text = "보내기";
            this.CliSend.UseVisualStyleBackColor = true;
            this.CliSend.Click += new System.EventHandler(this.CliSend_Click);
            // 
            // CliMessage
            // 
            this.CliMessage.Location = new System.Drawing.Point(11, 529);
            this.CliMessage.Name = "CliMessage";
            this.CliMessage.Size = new System.Drawing.Size(306, 21);
            this.CliMessage.TabIndex = 11;
            // 
            // CliChatting
            // 
            this.CliChatting.Location = new System.Drawing.Point(10, 208);
            this.CliChatting.Name = "CliChatting";
            this.CliChatting.Size = new System.Drawing.Size(388, 315);
            this.CliChatting.TabIndex = 10;
            this.CliChatting.Text = "";
            // 
            // CliBack
            // 
            this.CliBack.Location = new System.Drawing.Point(215, 144);
            this.CliBack.Name = "CliBack";
            this.CliBack.Size = new System.Drawing.Size(183, 58);
            this.CliBack.TabIndex = 9;
            this.CliBack.Text = "뒤로가기";
            this.CliBack.UseVisualStyleBackColor = true;
            // 
            // CliEnter
            // 
            this.CliEnter.Location = new System.Drawing.Point(10, 144);
            this.CliEnter.Name = "CliEnter";
            this.CliEnter.Size = new System.Drawing.Size(183, 58);
            this.CliEnter.TabIndex = 8;
            this.CliEnter.Text = "참여하기";
            this.CliEnter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientRename);
            this.groupBox1.Controls.Add(this.ClientName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClientPort);
            this.groupBox1.Controls.Add(this.ClientIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "접속할 채팅방";
            // 
            // ClientDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 559);
            this.Controls.Add(this.CliSend);
            this.Controls.Add(this.CliMessage);
            this.Controls.Add(this.CliChatting);
            this.Controls.Add(this.CliBack);
            this.Controls.Add(this.CliEnter);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientDevice";
            this.Text = "ClientDevice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientDevice_FormClosing);
            this.Load += new System.EventHandler(this.ClientDevice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientRename;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientPort;
        private System.Windows.Forms.TextBox ClientIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CliSend;
        private System.Windows.Forms.TextBox CliMessage;
        private System.Windows.Forms.RichTextBox CliChatting;
        private System.Windows.Forms.Button CliBack;
        private System.Windows.Forms.Button CliEnter;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}