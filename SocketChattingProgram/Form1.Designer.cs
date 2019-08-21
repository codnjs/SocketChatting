namespace SocketChattingProgram
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Serverbtn = new System.Windows.Forms.Button();
            this.Clientbtn = new System.Windows.Forms.Button();
            this.Endbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(96, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "소켓을 이용한 채팅프로그램";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Serverbtn
            // 
            this.Serverbtn.Location = new System.Drawing.Point(12, 129);
            this.Serverbtn.Name = "Serverbtn";
            this.Serverbtn.Size = new System.Drawing.Size(162, 96);
            this.Serverbtn.TabIndex = 1;
            this.Serverbtn.Text = "채팅방 만들기";
            this.Serverbtn.UseVisualStyleBackColor = true;
            this.Serverbtn.Click += new System.EventHandler(this.Serverbtn_Click);
            // 
            // Clientbtn
            // 
            this.Clientbtn.Location = new System.Drawing.Point(277, 129);
            this.Clientbtn.Name = "Clientbtn";
            this.Clientbtn.Size = new System.Drawing.Size(162, 96);
            this.Clientbtn.TabIndex = 2;
            this.Clientbtn.Text = "채팅방 참여하기";
            this.Clientbtn.UseVisualStyleBackColor = true;
            this.Clientbtn.Click += new System.EventHandler(this.Clientbtn_Click);
            // 
            // Endbtn
            // 
            this.Endbtn.Location = new System.Drawing.Point(180, 129);
            this.Endbtn.Name = "Endbtn";
            this.Endbtn.Size = new System.Drawing.Size(91, 96);
            this.Endbtn.TabIndex = 3;
            this.Endbtn.Text = "종료";
            this.Endbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "서버 시작";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "클라이언트 시작";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Endbtn);
            this.Controls.Add(this.Clientbtn);
            this.Controls.Add(this.Serverbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Serverbtn;
        private System.Windows.Forms.Button Clientbtn;
        private System.Windows.Forms.Button Endbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

