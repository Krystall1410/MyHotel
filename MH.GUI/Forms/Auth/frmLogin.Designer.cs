namespace MH.GUI.Forms.Auth
{
    partial class frmLogin
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
            lnkRegister = new LinkLabel();
            lblNoAccount = new Label();
            chkRemember = new CheckBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(79, 70, 229);
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lnkRegister.LinkColor = Color.FromArgb(79, 70, 229);
            lnkRegister.Location = new Point(230, 206);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(51, 15);
            lnkRegister.TabIndex = 8;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Đăng ký";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked_1;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Segoe UI", 9F);
            lblNoAccount.ForeColor = Color.DimGray;
            lblNoAccount.Location = new Point(83, 206);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(129, 15);
            lblNoAccount.TabIndex = 7;
            lblNoAccount.Text = "Bạn chưa có tài khoản?";
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI", 9F);
            chkRemember.ForeColor = Color.DimGray;
            chkRemember.Location = new Point(87, 148);
            chkRemember.Margin = new Padding(3, 2, 3, 2);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(102, 19);
            chkRemember.TabIndex = 6;
            chkRemember.Text = "Nhớ mật khẩu";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(87, 171);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(245, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(87, 122);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(245, 25);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.5F);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(83, 104);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(87, 79);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(245, 25);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.5F);
            lblUsername.ForeColor = Color.DimGray;
            lblUsername.Location = new Point(83, 61);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.DarkSlateBlue;
            lblWelcome.Location = new Point(8, 7);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(414, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hệ thống quản lý khách sạn MyHotel";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(419, 230);
            Controls.Add(lnkRegister);
            Controls.Add(lblNoAccount);
            Controls.Add(chkRemember);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblWelcome);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - MyHotel";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
    }
}