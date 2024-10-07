namespace CreateStudent
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
            this.ldlStudentId = new System.Windows.Forms.Label();
            this.ldlName = new System.Windows.Forms.Label();
            this.ldlStudentList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.lstStudentId = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ldlStudentId
            // 
            this.ldlStudentId.AutoSize = true;
            this.ldlStudentId.Location = new System.Drawing.Point(33, 54);
            this.ldlStudentId.Name = "ldlStudentId";
            this.ldlStudentId.Size = new System.Drawing.Size(37, 15);
            this.ldlStudentId.TabIndex = 0;
            this.ldlStudentId.Text = "학번";
            // 
            // ldlName
            // 
            this.ldlName.AutoSize = true;
            this.ldlName.Location = new System.Drawing.Point(33, 124);
            this.ldlName.Name = "ldlName";
            this.ldlName.Size = new System.Drawing.Size(37, 15);
            this.ldlName.TabIndex = 0;
            this.ldlName.Text = "이름";
            this.ldlName.Click += new System.EventHandler(this.ldlName_Click);
            // 
            // ldlStudentList
            // 
            this.ldlStudentList.AutoSize = true;
            this.ldlStudentList.Location = new System.Drawing.Point(438, 51);
            this.ldlStudentList.Name = "ldlStudentList";
            this.ldlStudentList.Size = new System.Drawing.Size(87, 15);
            this.ldlStudentList.TabIndex = 0;
            this.ldlStudentList.Text = "학생 리스트";
            this.ldlStudentList.Click += new System.EventHandler(this.ldlName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "프로필";
            this.label1.Click += new System.EventHandler(this.ldlName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(89, 51);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(195, 25);
            this.txtStudentId.TabIndex = 1;
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(104, 197);
            this.txtProfile.Multiline = true;
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(195, 223);
            this.txtProfile.TabIndex = 1;
            this.txtProfile.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lstStudentId
            // 
            this.lstStudentId.FormattingEnabled = true;
            this.lstStudentId.ItemHeight = 15;
            this.lstStudentId.Location = new System.Drawing.Point(441, 87);
            this.lstStudentId.Name = "lstStudentId";
            this.lstStudentId.Size = new System.Drawing.Size(169, 304);
            this.lstStudentId.TabIndex = 2;
            this.lstStudentId.SelectedIndexChanged += new System.EventHandler(this.callback_lstStudentId_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.callback_btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(431, 443);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.callback_btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstStudentId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ldlStudentList);
            this.Controls.Add(this.ldlName);
            this.Controls.Add(this.ldlStudentId);
            this.Name = "Form1";
            this.Text = "종료";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldlStudentId;
        private System.Windows.Forms.Label ldlName;
        private System.Windows.Forms.Label ldlStudentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.ListBox lstStudentId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}

