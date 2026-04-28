namespace MH.GUI.Forms.Options
{
    partial class frmChucVu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvChucVu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ CHỨC VỤ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SlateBlue;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(620, 75);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 40);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(380, 80);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên chức vụ...";
            txtTimKiem.Size = new Size(230, 30);
            txtTimKiem.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(260, 75);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.MediumSlateBlue;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(140, 75);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkSlateBlue;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(20, 75);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvChucVu
            // 
            dgvChucVu.AllowUserToAddRows = false;
            dgvChucVu.AllowUserToDeleteRows = false;
            dgvChucVu.AllowUserToResizeColumns = false;
            dgvChucVu.AllowUserToResizeRows = false;
            dgvChucVu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChucVu.BackgroundColor = Color.White;
            dgvChucVu.BorderStyle = BorderStyle.None;
            dgvChucVu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChucVu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChucVu.ColumnHeadersHeight = 40;
            dgvChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 234, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChucVu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChucVu.EnableHeadersVisualStyles = false;
            dgvChucVu.Location = new Point(0, 140);
            dgvChucVu.Margin = new Padding(0);
            dgvChucVu.Name = "dgvChucVu";
            dgvChucVu.ReadOnly = true;
            dgvChucVu.RowHeadersVisible = false;
            dgvChucVu.RowHeadersWidth = 51;
            dgvChucVu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvChucVu.RowTemplate.Height = 40;
            dgvChucVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChucVu.Size = new Size(880, 440);
            dgvChucVu.TabIndex = 3;
            // 
            // frmChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(880, 580);
            Controls.Add(dgvChucVu);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblTitle);
            Name = "frmChucVu";
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvChucVu;
    }
}