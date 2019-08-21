namespace SocketChattingProgram
{
    partial class ServerDevice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServerRename = new System.Windows.Forms.Button();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.ServerIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetEnter = new System.Windows.Forms.Button();
            this.SetBack = new System.Windows.Forms.Button();
            this.SerChatting = new System.Windows.Forms.RichTextBox();
            this.SerMessage = new System.Windows.Forms.TextBox();
            this.SerSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerRename);
            this.groupBox1.Controls.Add(this.ServerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ServerPort);
            this.groupBox1.Controls.Add(this.ServerIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅방 설정";
            // 
            // ServerRename
            // 
            this.ServerRename.Location = new System.Drawing.Point(300, 96);
            this.ServerRename.Name = "ServerRename";
            this.ServerRename.Size = new System.Drawing.Size(75, 23);
            this.ServerRename.TabIndex = 6;
            this.ServerRename.Text = "변경";
            this.ServerRename.UseVisualStyleBackColor = true;
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(112, 98);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(182, 21);
            this.ServerName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "채팅 참여 이름";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // ServerPort
            // 
            this.ServerPort.Location = new System.Drawing.Point(80, 60);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(276, 21);
            this.ServerPort.TabIndex = 3;
            // 
            // ServerIp
            // 
            this.ServerIp.Location = new System.Drawing.Point(80, 28);
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.Size = new System.Drawing.Size(276, 21);
            this.ServerIp.TabIndex = 2;
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
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // SetEnter
            // 
            this.SetEnter.Location = new System.Drawing.Point(12, 148);
            this.SetEnter.Name = "SetEnter";
            this.SetEnter.Size = new System.Drawing.Size(183, 58);
            this.SetEnter.TabIndex = 1;
            this.SetEnter.Text = "열기";
            this.SetEnter.UseVisualStyleBackColor = true;
            this.SetEnter.Click += new System.EventHandler(this.SetEnter_Click);
            // 
            // SetBack
            // 
            this.SetBack.Location = new System.Drawing.Point(217, 148);
            this.SetBack.Name = "SetBack";
            this.SetBack.Size = new System.Drawing.Size(183, 58);
            this.SetBack.TabIndex = 2;
            this.SetBack.Text = "뒤로가기";
            this.SetBack.UseVisualStyleBackColor = true;
            // 
            // SerChatting
            // 
            this.SerChatting.Location = new System.Drawing.Point(12, 212);
            this.SerChatting.Name = "SerChatting";
            this.SerChatting.Size = new System.Drawing.Size(388, 315);
            this.SerChatting.TabIndex = 4;
            this.SerChatting.Text = "";
            // 
            // SerMessage
            // 
            this.SerMessage.Location = new System.Drawing.Point(13, 533);
            this.SerMessage.Name = "SerMessage";
            this.SerMessage.Size = new System.Drawing.Size(306, 21);
            this.SerMessage.TabIndex = 5;
            // 
            // SerSend
            // 
            this.SerSend.Location = new System.Drawing.Point(325, 531);
            this.SerSend.Name = "SerSend";
            this.SerSend.Size = new System.Drawing.Size(75, 23);
            this.SerSend.TabIndex = 6;
            this.SerSend.Text = "보내기";
            this.SerSend.UseVisualStyleBackColor = true;
            // 
            // ServerDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 566);
            this.Controls.Add(this.SerSend);
            this.Controls.Add(this.SerMessage);
            this.Controls.Add(this.SerChatting);
            this.Controls.Add(this.SetBack);
            this.Controls.Add(this.SetEnter);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServerDevice";
            this.Text = "ServerDevice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerDevice_FormClosing);
            this.Load += new System.EventHandler(this.ServerDevice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerPort;
        private System.Windows.Forms.TextBox ServerIp;
        private System.Windows.Forms.Button ServerRename;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Button SetEnter;
        private System.Windows.Forms.Button SetBack;
        private System.Windows.Forms.RichTextBox SerChatting;
        private System.Windows.Forms.TextBox SerMessage;
        private System.Windows.Forms.Button SerSend;
    }
}