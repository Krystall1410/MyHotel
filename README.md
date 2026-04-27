# 🏨 Dự Án Quản Lý Khách Sạn - MyHotel

**Dự án này sử dụng kiến trúc 3-Layer (3 lớp) và Entity Framework Core (Database First). Đề nghị các thành viên đọc kỹ hướng dẫn này để đảm bảo code sạch, dễ bảo trì và không gây xung đột hệ thống.**

---
# PHẢI ĐỌC TRƯỚC KHI PUSH HOẶC PULL VỀ?

# 1. Gom tất cả thay đổi của mình lại
git add .
git commit -m "feat: nội dung bạn vừa làm"

# 2. Làm sạch rác phát sinh khi chạy thử code
git clean -fd

# 3. Kéo code mới nhất của các bạn khác về (tránh đè lên nhau)
git pull origin master

# 4. Kiểm tra lại lần cuối
git status

# 5. Nếu mọi thứ ok (chỉ hiện file code), thì mới push
git push origin <ten_nhanh_cua_ban>

## 🏗 1. Cấu Trúc 3 Lớp & Luồng Dữ Liệu (Data Flow)
Dự án được chia làm các Project con, tuân thủ luồng: **GUI ⇄ BLL ⇄ DAL ⇄ Database**.

* **MH.Domain (Entities):**
    * Chứa các Class đại diện cho bảng (như **NhanVien.cs**, **Phong.cs**).
    * **Lưu ý:** Đây là "ngôn ngữ chung". Tất cả các tầng khác đều phải tham chiếu (**Reference**) vào đây.

* **MH.DAL (Data Access Layer):**
    * **Nhiệm vụ:** Chỉ thực hiện **CRUD** (Thêm, Xóa, Sửa, Lấy dữ liệu).
    * **Tuyệt đối:** Không viết **MessageBox** hay **Logic** kiểm tra điều kiện ở đây.

* **MH.BLL (Business Logic Layer):**
    * **Nhiệm vụ:** "Bộ não" của dự án. Kiểm tra tính hợp lệ (VD: Ngày đặt phòng phải sau ngày hiện tại) trước khi gửi xuống **DAL**.

* **MH.GUI (Presentation Layer):**
    * **Nhiệm vụ:** Hiển thị và nhận dữ liệu từ người dùng.
    * **Quy tắc:** Không được gọi trực tiếp tầng **DAL**. Phải gọi qua **BLL**.

---

## 🗄 2. Lưu Ý "Sống Còn" Về Thực Thể (Entities)
Các file trong **MH.Domain/entities** được sinh ra tự động từ SQL Server.

* **⚠️ CẤM SỬA TAY:** Không được thêm/xóa thuộc tính trực tiếp trong các file class này. Khi trưởng nhóm chạy lệnh cập nhật DB, mọi thay đổi viết tay của bạn sẽ bị **XÓA SẠCH**.
* **Mở rộng code:** Nếu muốn viết thêm hàm xử lý cho thực thể, hãy dùng từ khóa **partial class** ở một file riêng.
* **Namespace:** Luôn kiểm tra dòng đầu tiên phải là **namespace MH.Domain.entities;**.

---

## 🔄 3. Quy Trình Đồng Bộ Database (Migration)
Chúng ta không gửi file **.sql**. Chúng ta dùng **Migration** để đồng bộ cấu trúc DB qua GitHub.

**Cách để "mọc" Database trên máy bạn:**
1.  **git pull** code mới nhất về.
2.  Mở **Package Manager Console (PMC)**.
3.  Chọn Default Project là **MH.DAL**.
4.  Gõ lệnh: **Update-Database**.
5.  **Lưu ý:** Nếu lỗi kết nối, hãy mở file **MyHotelContext.cs** trong **DAL** và sửa lại **Server=.\SQLEXPRESS** cho đúng tên **Instance SQL** của máy bạn.

**Lưu ý khi muốn đổi cấu trúc bảng (Thêm cột, thêm bảng):**
1.  Sửa bảng trong SQL Server của bạn.
2.  Chạy lệnh **Scaffold** để cập nhật Code:
    `Scaffold-DbContext "..." Microsoft.EntityFrameworkCore.SqlServer -OutputDir entities -Force` (Chạy tại MH.Domain).
3.  Tạo bản vẽ Migration mới: **Add-Migration Ten_Migration_Moi -Project MH.DAL**.
4.  **Push** code lên GitHub để người khác cập nhật.

---

## ☁️ 4. Quy Tắc Sử Dụng Git (Tránh Xung Đột)
* **Nhánh làm việc:** Nhánh chính là **master**. Nhánh **main** cũ đã bỏ, không đẩy code vào đó.
* **⚠️ TUYỆT ĐỐI KHÔNG PUSH TRỰC TIẾP LÊN MASTER:** * Mỗi thành viên phải tạo một nhánh riêng từ `master` để làm việc (VD: `git checkout -b feature/login`).
    * Sau khi hoàn thành và test kỹ trên nhánh cá nhân, mới thực hiện tạo **Pull Request** để gộp vào `master`. Việc này giúp bảo vệ nhánh chính không bị lỗi hoặc xung đột bất ngờ.
* **Quy tắc ghi nội dung Commit:**
    * **KHÔNG** ghi linh tinh (VD: "fix", "update", "asdfgh").
    * **PHẢI** ghi đúng mục đích thay đổi code để dễ dàng theo dõi lịch sử dự án. 
    * Cấu trúc khuyên dùng: `[Loại] - [Mô tả ngắn gọn]` 
    * VD: `feat: Thêm chức năng đăng nhập`, `fix: Sửa lỗi hiển thị danh sách phòng`.
* **Thứ tự đẩy code:**
    1.  **git add .**
    2.  **git commit -m "mô tả rõ ràng"**
    3.  **git pull origin master --rebase** (Để gộp code của người khác vào trước).
    4.  **git push origin master**.
* **Lỗi index.lock:** Nếu hiện lỗi này, hãy xóa file **.git/index.lock** trong thư mục dự án rồi chạy lại lệnh.

* ###  Quy Tắc Sử Dụng Git & Làm Việc Nhóm (Teamwork)

Để dự án không bị xung đột, chúng ta tuân thủ quy trình làm việc trên **Nhánh riêng (Branch)**. Tuyệt đối **KHÔNG PUSH TRỰC TIẾP LÊN MASTER**.

#### **A. Lệnh dành cho người mới bắt đầu (Lần đầu nhận nhánh):**
1. Cập nhật danh sách nhánh mới nhất từ GitHub:
   ```bash
   git fetch origin
2. Chuyển sang nhánh được phân công (Ví dụ nhánh của bạn là feature-phong):

git checkout feature-phong

**B. Quy trình làm việc hàng ngày (Code -> Commit -> Push):
Mỗi khi hoàn thành một phần việc, hãy thực hiện bộ lệnh sau:

1. Lưu các thay đổi vào hàng chờ:

git add .

2. Lưu lại bản ghi (Commit) - Phải ghi đúng mục đích, KHÔNG ghi linh tinh (như "abc", "fix"):

git commit -m "feat: hoàn thành chức năng tìm kiếm phòng"
3. Đẩy code lên đúng nhánh của mình trên GitHub:

git push origin feature-phong

**C. Cách cập nhật Database và Code mới từ Master:
Khi trưởng nhóm thông báo đã gộp code mới hoặc có Migration mới vào master, bạn cần cập nhật nhánh của mình:


1.  Chuyển về master để lấy code mới:

git checkout master
git pull origin master

2.  Quay lại nhánh của bạn và gộp code từ master vào:

git checkout feature-phong
git merge master

3. Cập nhật Database (nếu có Migration mới):
Mở PMC trong Visual Studio, chọn Default Project là MH.DAL và gõ:

PowerShell
Update-Database
⚠️ Quy tắc Commit Message (Bắt buộc):
feat: Cho chức năng mới (VD: feat: làm giao diện nhân viên).

fix: Cho việc sửa lỗi (VD: fix: sửa lỗi không lưu được khách hàng).

refactor: Cho việc tối ưu code nhưng không đổi chức năng.

---

## 🛠 5. Giải Quyết Lỗi Thường Gặp
* **Lỗi Build Failed:** Do code đang có gạch chân đỏ. Phải sửa hết lỗi cú pháp mới được chạy **Update-Database** hoặc **Add-Migration**.
* **Lỗi NuGet (NU1605):** Nếu thấy lỗi phiên bản thư viện (8.0.x vs 10.0.x), hãy chuột phải vào **Solution** -> chọn **Manage NuGet Packages** -> tab **Consolidate** để đưa tất cả về cùng một phiên bản (khuyên dùng **8.0.10**).
* **Lỗi Reference:** Nếu gõ tên lớp mà Visual Studio không nhận (hiện gạch đỏ), hãy kiểm tra xem Project hiện tại đã **Add Project Reference** tới lớp chứa nó chưa.

---

## ✍️ 6. Quy Tắc Đặt Tên (Coding Convention)
* **Tên Class/Hàm:** Viết hoa chữ cái đầu (**PascalCase**). VD: **GetListNhanVien()**.
* **Tên Biến/Tham số:** Viết thường chữ cái đầu (**camelCase**). VD: **maNhanVien**.
* **Namespace:** Phải khớp với thư mục chứa file. VD: **namespace MH.BLL.Services**.

---

## 🔗 Về tham chiếu (Reference)
**Bạn hãy kiểm tra lại lần cuối:**
* **MH.DAL** phải Reference **MH.Domain**.
* **MH.BLL** phải Reference **MH.DAL** và **MH.Domain**.
* **MH.GUI** phải Reference **MH.BLL** và **MH.Domain**.
* **⚠️ QUAN TRỌNG:** **Không bao giờ** cho **MH.Domain** tham chiếu ngược lại các tầng khác.
Chạy lệnh Scaffold để cập nhật Code:
Scaffold-DbContext "..." Microsoft.EntityFrameworkCore.SqlServer -OutputDir entities -Force (Chạy tại MH.Domain).

Tạo bản vẽ Migration mới: Add-Migration Ten_Migration_Moi -Project MH.DAL.

Push code lên GitHub để người khác cập nhật.



⚠️ QUAN TRỌNG: Không bao giờ cho MH.Domain tham chiếu ngược lại các tầng khác.
