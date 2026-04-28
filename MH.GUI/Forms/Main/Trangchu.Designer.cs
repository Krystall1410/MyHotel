namespace MH.GUI.Forms.Main
{
    partial class Trangchu
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
            pnlSidebar = new Panel();
            pnSubMenuHeThong = new Panel();
            btnTaiKhoan = new Button();
            btnChucVu = new Button();
            btnQuanLiNhanSu = new Button();
            btnHeThong = new Button();
            pnSubMenuTaiChinh = new Panel();
            btnDoanhThu = new Button();
            btnLuong = new Button();
            btnTaiChinh = new Button();
            pnSubMenuDieuHanh = new Panel();
            btnHieuSuat = new Button();
            btnLichLamViec = new Button();
            btnDieuHanh = new Button();
            pnSubMenuKhachHang = new Panel();
            btnLichSuThue = new Button();
            btnDanhSachKhachHang = new Button();
            btnKhachHang = new Button();
            pnSubMenuLeTan = new Panel();
            btnThanhToan = new Button();
            btnSoDoPhong = new Button();
            btnTiepNhanKhach = new Button();
            btnMenuLeTan = new Button();
            pnlLogo = new Panel();
            lblPMS = new Label();
            lblIcon = new Label();
            pnlHeader = new Panel();
            btnLogout = new Button();
            lblTitle = new Label();
            menuStrip1 = new MenuStrip();
            pnMain = new Panel();
            menuStrip2 = new MenuStrip();
            menuStrip3 = new MenuStrip();
            pnlSidebar.SuspendLayout();
            pnSubMenuHeThong.SuspendLayout();
            pnSubMenuTaiChinh.SuspendLayout();
            pnSubMenuDieuHanh.SuspendLayout();
            pnSubMenuKhachHang.SuspendLayout();
            pnSubMenuLeTan.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.DarkSlateBlue;
            pnlSidebar.Controls.Add(pnSubMenuHeThong);
            pnlSidebar.Controls.Add(btnHeThong);
            pnlSidebar.Controls.Add(pnSubMenuTaiChinh);
            pnlSidebar.Controls.Add(btnTaiChinh);
            pnlSidebar.Controls.Add(pnSubMenuDieuHanh);
            pnlSidebar.Controls.Add(btnDieuHanh);
            pnlSidebar.Controls.Add(pnSubMenuKhachHang);
            pnlSidebar.Controls.Add(btnKhachHang);
            pnlSidebar.Controls.Add(pnSubMenuLeTan);
            pnlSidebar.Controls.Add(btnMenuLeTan);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 1175);
            pnlSidebar.TabIndex = 0;
            // 
            // pnSubMenuHeThong
            // 
            pnSubMenuHeThong.BackColor = Color.SlateBlue;
            pnSubMenuHeThong.Controls.Add(btnTaiKhoan);
            pnSubMenuHeThong.Controls.Add(btnChucVu);
            pnSubMenuHeThong.Controls.Add(btnQuanLiNhanSu);
            pnSubMenuHeThong.Dock = DockStyle.Top;
            pnSubMenuHeThong.Location = new Point(0, 954);
            pnSubMenuHeThong.Name = "pnSubMenuHeThong";
            pnSubMenuHeThong.Size = new Size(250, 189);
            pnSubMenuHeThong.TabIndex = 10;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaiKhoan.ForeColor = Color.White;
            btnTaiKhoan.Location = new Point(0, 120);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(250, 60);
            btnTaiKhoan.TabIndex = 2;
            btnTaiKhoan.Text = "Quản lý Tài khoản";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnChucVu
            // 
            btnChucVu.Dock = DockStyle.Top;
            btnChucVu.FlatAppearance.BorderSize = 0;
            btnChucVu.FlatStyle = FlatStyle.Flat;
            btnChucVu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChucVu.ForeColor = Color.White;
            btnChucVu.Location = new Point(0, 60);
            btnChucVu.Name = "btnChucVu";
            btnChucVu.Size = new Size(250, 60);
            btnChucVu.TabIndex = 1;
            btnChucVu.Text = "Quản lí chức vụ";
            btnChucVu.TextAlign = ContentAlignment.MiddleLeft;
            btnChucVu.UseVisualStyleBackColor = true;
            btnChucVu.Click += btnLoaiPhong_Click;
            // 
            // btnQuanLiNhanSu
            // 
            btnQuanLiNhanSu.Dock = DockStyle.Top;
            btnQuanLiNhanSu.FlatAppearance.BorderSize = 0;
            btnQuanLiNhanSu.FlatStyle = FlatStyle.Flat;
            btnQuanLiNhanSu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanLiNhanSu.ForeColor = Color.White;
            btnQuanLiNhanSu.Location = new Point(0, 0);
            btnQuanLiNhanSu.Name = "btnQuanLiNhanSu";
            btnQuanLiNhanSu.Size = new Size(250, 60);
            btnQuanLiNhanSu.TabIndex = 0;
            btnQuanLiNhanSu.Text = "Quản lý Nhân sự";
            btnQuanLiNhanSu.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLiNhanSu.UseVisualStyleBackColor = true;
            // 
            // btnHeThong
            // 
            btnHeThong.Dock = DockStyle.Top;
            btnHeThong.FlatAppearance.BorderSize = 0;
            btnHeThong.FlatStyle = FlatStyle.Flat;
            btnHeThong.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeThong.ForeColor = Color.White;
            btnHeThong.Location = new Point(0, 894);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.Size = new Size(250, 60);
            btnHeThong.TabIndex = 10;
            btnHeThong.Text = "⚙️ Hệ Thống";
            btnHeThong.TextAlign = ContentAlignment.MiddleLeft;
            btnHeThong.UseVisualStyleBackColor = true;
            btnHeThong.Click += btnHeThong_Click;
            // 
            // pnSubMenuTaiChinh
            // 
            pnSubMenuTaiChinh.BackColor = Color.SlateBlue;
            pnSubMenuTaiChinh.Controls.Add(btnDoanhThu);
            pnSubMenuTaiChinh.Controls.Add(btnLuong);
            pnSubMenuTaiChinh.Dock = DockStyle.Top;
            pnSubMenuTaiChinh.Location = new Point(0, 767);
            pnSubMenuTaiChinh.Name = "pnSubMenuTaiChinh";
            pnSubMenuTaiChinh.Size = new Size(250, 127);
            pnSubMenuTaiChinh.TabIndex = 0;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.Dock = DockStyle.Top;
            btnDoanhThu.FlatAppearance.BorderSize = 0;
            btnDoanhThu.FlatStyle = FlatStyle.Flat;
            btnDoanhThu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoanhThu.ForeColor = Color.White;
            btnDoanhThu.Location = new Point(0, 60);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(250, 67);
            btnDoanhThu.TabIndex = 1;
            btnDoanhThu.Text = "Báo cáo doanh thu";
            btnDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            btnDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnLuong
            // 
            btnLuong.Dock = DockStyle.Top;
            btnLuong.FlatAppearance.BorderSize = 0;
            btnLuong.FlatStyle = FlatStyle.Flat;
            btnLuong.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuong.ForeColor = Color.White;
            btnLuong.Location = new Point(0, 0);
            btnLuong.Name = "btnLuong";
            btnLuong.Size = new Size(250, 60);
            btnLuong.TabIndex = 0;
            btnLuong.Text = "Quản lý Lương";
            btnLuong.TextAlign = ContentAlignment.MiddleLeft;
            btnLuong.UseVisualStyleBackColor = true;
            // 
            // btnTaiChinh
            // 
            btnTaiChinh.Dock = DockStyle.Top;
            btnTaiChinh.FlatAppearance.BorderSize = 0;
            btnTaiChinh.FlatStyle = FlatStyle.Flat;
            btnTaiChinh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaiChinh.ForeColor = Color.White;
            btnTaiChinh.Location = new Point(0, 707);
            btnTaiChinh.Name = "btnTaiChinh";
            btnTaiChinh.Size = new Size(250, 60);
            btnTaiChinh.TabIndex = 3;
            btnTaiChinh.Text = "💰 Tài Chính";
            btnTaiChinh.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiChinh.UseVisualStyleBackColor = true;
            btnTaiChinh.Click += btnTaiChinh_Click;
            // 
            // pnSubMenuDieuHanh
            // 
            pnSubMenuDieuHanh.BackColor = Color.SlateBlue;
            pnSubMenuDieuHanh.Controls.Add(btnHieuSuat);
            pnSubMenuDieuHanh.Controls.Add(btnLichLamViec);
            pnSubMenuDieuHanh.Dock = DockStyle.Top;
            pnSubMenuDieuHanh.Location = new Point(0, 582);
            pnSubMenuDieuHanh.Name = "pnSubMenuDieuHanh";
            pnSubMenuDieuHanh.Size = new Size(250, 125);
            pnSubMenuDieuHanh.TabIndex = 9;
            // 
            // btnHieuSuat
            // 
            btnHieuSuat.Dock = DockStyle.Top;
            btnHieuSuat.FlatAppearance.BorderSize = 0;
            btnHieuSuat.FlatStyle = FlatStyle.Flat;
            btnHieuSuat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHieuSuat.ForeColor = Color.White;
            btnHieuSuat.Location = new Point(0, 60);
            btnHieuSuat.Name = "btnHieuSuat";
            btnHieuSuat.Size = new Size(250, 60);
            btnHieuSuat.TabIndex = 12;
            btnHieuSuat.Text = "Hiệu suất công việc";
            btnHieuSuat.TextAlign = ContentAlignment.MiddleLeft;
            btnHieuSuat.UseVisualStyleBackColor = true;
            // 
            // btnLichLamViec
            // 
            btnLichLamViec.Dock = DockStyle.Top;
            btnLichLamViec.FlatAppearance.BorderSize = 0;
            btnLichLamViec.FlatStyle = FlatStyle.Flat;
            btnLichLamViec.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLichLamViec.ForeColor = Color.White;
            btnLichLamViec.Location = new Point(0, 0);
            btnLichLamViec.Name = "btnLichLamViec";
            btnLichLamViec.Size = new Size(250, 60);
            btnLichLamViec.TabIndex = 11;
            btnLichLamViec.Text = "Lịch làm việc ";
            btnLichLamViec.TextAlign = ContentAlignment.MiddleLeft;
            btnLichLamViec.UseVisualStyleBackColor = true;
            // 
            // btnDieuHanh
            // 
            btnDieuHanh.Dock = DockStyle.Top;
            btnDieuHanh.FlatAppearance.BorderSize = 0;
            btnDieuHanh.FlatStyle = FlatStyle.Flat;
            btnDieuHanh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDieuHanh.ForeColor = Color.White;
            btnDieuHanh.ImageAlign = ContentAlignment.MiddleRight;
            btnDieuHanh.Location = new Point(0, 522);
            btnDieuHanh.Name = "btnDieuHanh";
            btnDieuHanh.Size = new Size(250, 60);
            btnDieuHanh.TabIndex = 6;
            btnDieuHanh.Text = "📅 Điều Hành";
            btnDieuHanh.TextAlign = ContentAlignment.MiddleLeft;
            btnDieuHanh.UseVisualStyleBackColor = true;
            btnDieuHanh.Click += btnDieuHanh_Click;
            // 
            // pnSubMenuKhachHang
            // 
            pnSubMenuKhachHang.BackColor = Color.SlateBlue;
            pnSubMenuKhachHang.Controls.Add(btnLichSuThue);
            pnSubMenuKhachHang.Controls.Add(btnDanhSachKhachHang);
            pnSubMenuKhachHang.Dock = DockStyle.Top;
            pnSubMenuKhachHang.Location = new Point(0, 393);
            pnSubMenuKhachHang.Name = "pnSubMenuKhachHang";
            pnSubMenuKhachHang.Size = new Size(250, 129);
            pnSubMenuKhachHang.TabIndex = 8;
            // 
            // btnLichSuThue
            // 
            btnLichSuThue.BackColor = Color.SlateBlue;
            btnLichSuThue.Dock = DockStyle.Top;
            btnLichSuThue.FlatAppearance.BorderSize = 0;
            btnLichSuThue.FlatStyle = FlatStyle.Flat;
            btnLichSuThue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLichSuThue.ForeColor = Color.White;
            btnLichSuThue.Location = new Point(0, 60);
            btnLichSuThue.Name = "btnLichSuThue";
            btnLichSuThue.Size = new Size(250, 60);
            btnLichSuThue.TabIndex = 1;
            btnLichSuThue.Text = "Tra cứu lịch sử thuê";
            btnLichSuThue.TextAlign = ContentAlignment.MiddleLeft;
            btnLichSuThue.UseVisualStyleBackColor = false;
            // 
            // btnDanhSachKhachHang
            // 
            btnDanhSachKhachHang.Dock = DockStyle.Top;
            btnDanhSachKhachHang.FlatAppearance.BorderSize = 0;
            btnDanhSachKhachHang.FlatStyle = FlatStyle.Flat;
            btnDanhSachKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDanhSachKhachHang.ForeColor = Color.White;
            btnDanhSachKhachHang.Location = new Point(0, 0);
            btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            btnDanhSachKhachHang.Size = new Size(250, 60);
            btnDanhSachKhachHang.TabIndex = 0;
            btnDanhSachKhachHang.Text = "Danh sách khách hàng";
            btnDanhSachKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhSachKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Location = new Point(0, 333);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(250, 60);
            btnKhachHang.TabIndex = 2;
            btnKhachHang.Text = "👥 Khách Hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // pnSubMenuLeTan
            // 
            pnSubMenuLeTan.BackColor = Color.SlateBlue;
            pnSubMenuLeTan.Controls.Add(btnThanhToan);
            pnSubMenuLeTan.Controls.Add(btnSoDoPhong);
            pnSubMenuLeTan.Controls.Add(btnTiepNhanKhach);
            pnSubMenuLeTan.Dock = DockStyle.Top;
            pnSubMenuLeTan.Location = new Point(0, 154);
            pnSubMenuLeTan.Name = "pnSubMenuLeTan";
            pnSubMenuLeTan.Size = new Size(250, 179);
            pnSubMenuLeTan.TabIndex = 7;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Dock = DockStyle.Top;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(0, 118);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(250, 60);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnSoDoPhong
            // 
            btnSoDoPhong.Dock = DockStyle.Top;
            btnSoDoPhong.FlatAppearance.BorderSize = 0;
            btnSoDoPhong.FlatStyle = FlatStyle.Flat;
            btnSoDoPhong.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSoDoPhong.ForeColor = Color.White;
            btnSoDoPhong.Location = new Point(0, 59);
            btnSoDoPhong.Name = "btnSoDoPhong";
            btnSoDoPhong.Size = new Size(250, 59);
            btnSoDoPhong.TabIndex = 4;
            btnSoDoPhong.Text = "Sơ Đồ Phòng";
            btnSoDoPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnSoDoPhong.UseVisualStyleBackColor = true;
            btnSoDoPhong.Click += btnSoDoPhong_Click;
            // 
            // btnTiepNhanKhach
            // 
            btnTiepNhanKhach.Dock = DockStyle.Top;
            btnTiepNhanKhach.FlatAppearance.BorderSize = 0;
            btnTiepNhanKhach.FlatStyle = FlatStyle.Flat;
            btnTiepNhanKhach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTiepNhanKhach.ForeColor = Color.White;
            btnTiepNhanKhach.Location = new Point(0, 0);
            btnTiepNhanKhach.Name = "btnTiepNhanKhach";
            btnTiepNhanKhach.Size = new Size(250, 59);
            btnTiepNhanKhach.TabIndex = 5;
            btnTiepNhanKhach.Text = "Tiếp nhận khách hàng mới";
            btnTiepNhanKhach.TextAlign = ContentAlignment.MiddleLeft;
            btnTiepNhanKhach.UseVisualStyleBackColor = true;
            // 
            // btnMenuLeTan
            // 
            btnMenuLeTan.Dock = DockStyle.Top;
            btnMenuLeTan.FlatAppearance.BorderSize = 0;
            btnMenuLeTan.FlatStyle = FlatStyle.Flat;
            btnMenuLeTan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuLeTan.ForeColor = Color.White;
            btnMenuLeTan.Location = new Point(0, 85);
            btnMenuLeTan.Name = "btnMenuLeTan";
            btnMenuLeTan.Size = new Size(250, 69);
            btnMenuLeTan.TabIndex = 1;
            btnMenuLeTan.Text = "🏨 Lễ tân";
            btnMenuLeTan.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuLeTan.UseVisualStyleBackColor = true;
            btnMenuLeTan.Click += btnMenuLeTan_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(lblPMS);
            pnlLogo.Controls.Add(lblIcon);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 85);
            pnlLogo.TabIndex = 0;
            // 
            // lblPMS
            // 
            lblPMS.AutoSize = true;
            lblPMS.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPMS.ForeColor = Color.White;
            lblPMS.Location = new Point(72, 24);
            lblPMS.Name = "lblPMS";
            lblPMS.Size = new Size(82, 41);
            lblPMS.TabIndex = 1;
            lblPMS.Text = "PMS";
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIcon.ForeColor = Color.White;
            lblIcon.Location = new Point(11, 21);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(67, 46);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "🏨";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(menuStrip1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1148, 59);
            pnlHeader.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(954, 27);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DimGray;
            lblTitle.Location = new Point(3, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(121, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Trang chủ";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1148, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pnMain
            // 
            pnMain.Controls.Add(menuStrip2);
            pnMain.Controls.Add(menuStrip3);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(250, 59);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1148, 1116);
            pnMain.TabIndex = 2;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 3, 0, 3);
            menuStrip2.Size = new Size(1148, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Padding = new Padding(7, 3, 0, 3);
            menuStrip3.Size = new Size(1148, 24);
            menuStrip3.TabIndex = 2;
            menuStrip3.Text = "menuStrip3";
            // 
            // Trangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1398, 1175);
            Controls.Add(pnMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Name = "Trangchu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý khách sạn - MyHotel";
            pnlSidebar.ResumeLayout(false);
            pnSubMenuHeThong.ResumeLayout(false);
            pnSubMenuTaiChinh.ResumeLayout(false);
            pnSubMenuDieuHanh.ResumeLayout(false);
            pnSubMenuKhachHang.ResumeLayout(false);
            pnSubMenuLeTan.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblPMS;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnMain;
        private Button btnMenuLeTan;
        private Button btnKhachHang;
        private Button btnSoDoPhong;
        private Button btnTaiChinh;
        private Button btnDieuHanh;
        private Button btnTiepNhanKhach;
        private Panel pnSubMenuLeTan;
        private Button btnThanhToan;
        private Panel pnSubMenuKhachHang;
        private Button btnDanhSachKhachHang;
        private Button btnLichSuThue;
        private Panel pnSubMenuHeThong;
        private Panel pnSubMenuTaiChinh;
        private Panel pnSubMenuDieuHanh;
        private Button btnLichLamViec;
        private Button btnHieuSuat;
        private Button btnDoanhThu;
        private Button btnLuong;
        private Button btnHeThong;
        private Button btnTaiKhoan;
        private Button btnChucVu;
        private Button btnQuanLiNhanSu;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private Button btnLogout;
    }
}