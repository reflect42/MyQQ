namespace MyQQ
{
    partial class Frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxLogin = new System.Windows.Forms.PictureBox();
            this.cboxRemember = new System.Windows.Forms.CheckBox();
            this.cboxAutoLogin = new System.Windows.Forms.CheckBox();
            this.linklbReg = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(138, 203);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(183, 14);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Location = new System.Drawing.Point(138, 232);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(183, 14);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // pboxMin
            // 
            this.pboxMin.BackColor = System.Drawing.Color.Transparent;
            this.pboxMin.Location = new System.Drawing.Point(372, 2);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(30, 24);
            this.pboxMin.TabIndex = 2;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.Location = new System.Drawing.Point(399, 2);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(30, 24);
            this.pboxClose.TabIndex = 3;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // pboxLogin
            // 
            this.pboxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pboxLogin.Location = new System.Drawing.Point(136, 285);
            this.pboxLogin.Name = "pboxLogin";
            this.pboxLogin.Size = new System.Drawing.Size(191, 34);
            this.pboxLogin.TabIndex = 4;
            this.pboxLogin.TabStop = false;
            this.pboxLogin.Click += new System.EventHandler(this.pboxLogin_Click);
            // 
            // cboxRemember
            // 
            this.cboxRemember.AutoSize = true;
            this.cboxRemember.Location = new System.Drawing.Point(133, 261);
            this.cboxRemember.Name = "cboxRemember";
            this.cboxRemember.Size = new System.Drawing.Size(15, 14);
            this.cboxRemember.TabIndex = 5;
            this.cboxRemember.UseVisualStyleBackColor = true;
            this.cboxRemember.CheckedChanged += new System.EventHandler(this.cboxRemember_CheckedChanged);
            // 
            // cboxAutoLogin
            // 
            this.cboxAutoLogin.AutoSize = true;
            this.cboxAutoLogin.Location = new System.Drawing.Point(259, 261);
            this.cboxAutoLogin.Name = "cboxAutoLogin";
            this.cboxAutoLogin.Size = new System.Drawing.Size(15, 14);
            this.cboxAutoLogin.TabIndex = 6;
            this.cboxAutoLogin.UseVisualStyleBackColor = true;
            // 
            // linklbReg
            // 
            this.linklbReg.AutoSize = true;
            this.linklbReg.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklbReg.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linklbReg.Location = new System.Drawing.Point(12, 307);
            this.linklbReg.Name = "linklbReg";
            this.linklbReg.Size = new System.Drawing.Size(53, 12);
            this.linklbReg.TabIndex = 7;
            this.linklbReg.TabStop = true;
            this.linklbReg.Text = "申请账号";
            this.linklbReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbReg_LinkClicked);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyQQ.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(430, 331);
            this.Controls.Add(this.linklbReg);
            this.Controls.Add(this.cboxAutoLogin);
            this.Controls.Add(this.cboxRemember);
            this.Controls.Add(this.pboxLogin);
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.pboxMin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Q友登录";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxLogin;
        private System.Windows.Forms.CheckBox cboxRemember;
        private System.Windows.Forms.CheckBox cboxAutoLogin;
        private System.Windows.Forms.LinkLabel linklbReg;

        
    }
}

