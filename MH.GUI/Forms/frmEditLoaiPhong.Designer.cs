namespace MH.GUI.Forms
{
    partial class frmEditLoaiPhong
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaLoai = new TextBox();
            txtTenLoai = new TextBox();
            txtGia = new TextBox();
            btnLuu = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 57);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 130);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "Giá ";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(86, 49);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(145, 23);
            txtMaLoai.TabIndex = 3;
            txtMaLoai.TextChanged += frmEditLoaiPhong_Load;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(86, 88);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(145, 23);
            txtTenLoai.TabIndex = 4;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(86, 122);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(145, 23);
            txtGia.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(222, 163);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(86, 9);
            label4.Name = "label4";
            label4.Size = new Size(135, 19);
            label4.TabIndex = 7;
            label4.Text = "THÔNG TIN PHÒNG";
            // 
            // frmEditLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 197);
            Controls.Add(label4);
            Controls.Add(btnLuu);
            Controls.Add(txtGia);
            Controls.Add(txtTenLoai);
            Controls.Add(txtMaLoai);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditLoaiPhong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaLoai;
        private TextBox txtTenLoai;
        private TextBox txtGia;
        private Button btnLuu;
        private Label label4;
    }
}