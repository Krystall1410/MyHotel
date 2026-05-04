namespace MH.GUI.Forms
{
    partial class frmLoaiPhong
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
            dgvLoaiPhong = new DataGridView();
            btnThemPhong = new Button();
            btnSuaPhong = new Button();
            btnXoaPhong = new Button();
            btnSearchPhong = new Button();
            txtSearchMaLoai = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Location = new Point(0, 167);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.RowHeadersWidth = 51;
            dgvLoaiPhong.Size = new Size(937, 411);
            dgvLoaiPhong.TabIndex = 0;
            // 
            // btnThemPhong
            // 
            btnThemPhong.BackColor = SystemColors.ButtonHighlight;
            btnThemPhong.Location = new Point(14, 80);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new Size(113, 23);
            btnThemPhong.TabIndex = 1;
            btnThemPhong.Text = "Thêm loại phòng";
            btnThemPhong.UseVisualStyleBackColor = false;
            btnThemPhong.Click += btnThemPhong_Click;
            // 
            // btnSuaPhong
            // 
            btnSuaPhong.BackColor = SystemColors.ButtonHighlight;
            btnSuaPhong.Location = new Point(166, 80);
            btnSuaPhong.Name = "btnSuaPhong";
            btnSuaPhong.Size = new Size(115, 23);
            btnSuaPhong.TabIndex = 2;
            btnSuaPhong.Text = "Cập nhật loại\r\n";
            btnSuaPhong.UseVisualStyleBackColor = false;
            btnSuaPhong.Click += btnSuaPhong_Click;
            // 
            // btnXoaPhong
            // 
            btnXoaPhong.BackColor = SystemColors.ButtonHighlight;
            btnXoaPhong.Location = new Point(334, 80);
            btnXoaPhong.Name = "btnXoaPhong";
            btnXoaPhong.Size = new Size(113, 23);
            btnXoaPhong.TabIndex = 3;
            btnXoaPhong.Text = "Xóa loại phòng";
            btnXoaPhong.UseVisualStyleBackColor = false;
            btnXoaPhong.Click += btnXoaPhong_Click;
            // 
            // btnSearchPhong
            // 
            btnSearchPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchPhong.BackColor = SystemColors.ButtonHighlight;
            btnSearchPhong.Location = new Point(666, 80);
            btnSearchPhong.Name = "btnSearchPhong";
            btnSearchPhong.Size = new Size(75, 23);
            btnSearchPhong.TabIndex = 4;
            btnSearchPhong.Text = "Tìm phòng";
            btnSearchPhong.UseVisualStyleBackColor = false;
            btnSearchPhong.Click += btnSearchPhong_Click;
            // 
            // txtSearchMaLoai
            // 
            txtSearchMaLoai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchMaLoai.Location = new Point(784, 81);
            txtSearchMaLoai.Name = "txtSearchMaLoai";
            txtSearchMaLoai.Size = new Size(153, 23);
            txtSearchMaLoai.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 6;
            label1.Text = "LOẠI PHÒNG";
            // 
            // frmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 590);
            Controls.Add(label1);
            Controls.Add(txtSearchMaLoai);
            Controls.Add(btnSearchPhong);
            Controls.Add(btnXoaPhong);
            Controls.Add(btnSuaPhong);
            Controls.Add(btnThemPhong);
            Controls.Add(dgvLoaiPhong);
            Name = "frmLoaiPhong";
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLoaiPhong;
        private Button btnThemPhong;
        private Button btnSuaPhong;
        private Button btnXoaPhong;
        private Button btnSearchPhong;
        private TextBox txtSearchMaLoai;
        private Label label1;
    }
}