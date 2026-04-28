namespace MH.GUI.Forms.CRUD
{
    partial class frmChucVu_Detail
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
            lblTitle = new Label();
            lblMaChucVu = new Label();
            txtMaChucVu = new TextBox();
            lblTenChucVu = new Label();
            txtTenChucVu = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(40, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(282, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CẬP NHẬT CHỨC VỤ";
            // 
            // lblMaChucVu
            // 
            lblMaChucVu.AutoSize = true;
            lblMaChucVu.Font = new Font("Segoe UI", 10F);
            lblMaChucVu.Location = new Point(40, 80);
            lblMaChucVu.Name = "lblMaChucVu";
            lblMaChucVu.Size = new Size(98, 23);
            lblMaChucVu.TabIndex = 1;
            lblMaChucVu.Text = "Mã chức vụ";
            // 
            // txtMaChucVu
            // 
            txtMaChucVu.Font = new Font("Segoe UI", 10F);
            txtMaChucVu.Location = new Point(44, 110);
            txtMaChucVu.Name = "txtMaChucVu";
            txtMaChucVu.Size = new Size(300, 30);
            txtMaChucVu.TabIndex = 2;
            // 
            // lblTenChucVu
            // 
            lblTenChucVu.AutoSize = true;
            lblTenChucVu.Font = new Font("Segoe UI", 10F);
            lblTenChucVu.Location = new Point(40, 160);
            lblTenChucVu.Name = "lblTenChucVu";
            lblTenChucVu.Size = new Size(100, 23);
            lblTenChucVu.TabIndex = 3;
            lblTenChucVu.Text = "Tên chức vụ";
            // 
            // txtTenChucVu
            // 
            txtTenChucVu.Font = new Font("Segoe UI", 10F);
            txtTenChucVu.Location = new Point(44, 190);
            txtTenChucVu.Name = "txtTenChucVu";
            txtTenChucVu.Size = new Size(300, 30);
            txtTenChucVu.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DarkSlateBlue;
            btnLuu.Font = new Font("Segoe UI", 11F);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(44, 250);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 45);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.IndianRed;
            btnHuy.Font = new Font("Segoe UI", 11F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(224, 250);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(120, 45);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // frmChucVu_Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 330);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtTenChucVu);
            Controls.Add(lblTenChucVu);
            Controls.Add(txtMaChucVu);
            Controls.Add(lblMaChucVu);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChucVu_Detail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết chức vụ";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaChucVu;
        public System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label lblTenChucVu;
        public System.Windows.Forms.TextBox txtTenChucVu;
        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnHuy;
    }
}