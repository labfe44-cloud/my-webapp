# 📘 Tài liệu nguồn (Source code)

Tài liệu này tóm tắt cấu trúc mã nguồn và hướng dẫn nhanh để chạy ứng dụng Xuan Phu Platform trong môi trường phát triển.

## ⚙️ Tổng quan dự án
- `XuanPhu.Web`: Ứng dụng ASP.NET Core MVC chính (frontend + backend nhẹ). Xử lý routing, controllers và views.
- `data/`: Chứa `AppDbContext` và cấu hình Entity Framework (quản lý kết nối và migration).
- `Controllers/`: Logic xử lý request và trả về Views/API.
- `Views/`: Razor views và layout, chịu trách nhiệm render giao diện HTML.

## 🗂 Cấu trúc chính (gợi ý)
- `Program.cs` / `appsettings.json` — điểm khởi động và cấu hình.
- `data/AppDbContext.cs` — DbContext và cấu hình EF Core.
- `Controllers/*` — các controller của ứng dụng.
- `Views/*` — Razor pages và partials.

## 🔧 Yêu cầu môi trường
- .NET 8 SDK (hoặc phiên bản tương thích với project).
- Docker (nếu chạy DB trong container theo cấu hình dev).
- Visual Studio Code + Dev Container (khuyến nghị dùng Terminal trong container để môi trường nhất quán).

## 🚀 Hướng dẫn chạy nhanh (Dev)
1. Mở terminal trong dev container (hoặc môi trường đã cài .NET):
```bash
cd XuanPhu.Web
```
2. Build project:
```bash
dotnet build
```
3. Chạy ứng dụng:
```bash
dotnet run
```
4. Mở trình duyệt vào:
```
http://localhost:5000
```

Lưu ý: port thực tế có thể khác tùy cấu hình `launchSettings.json` hoặc khi chạy trong container. Kiểm tra output của `dotnet run` để biết URL chính xác.

## 🧾 Thiết lập cơ sở dữ liệu (Dev)
Project mẫu sử dụng SQL Server (dev) trong Docker. Thông tin tham khảo (xem `docker-compose.dev.yml`):

- **Service**: `dev-sqlserver`
- **Server**: `dev-sqlserver,1433`
- **Database**: `XuanPhuDB`
- **User**: `sa`
- **Password**: được cấu hình trong `docker-compose.dev.yml` (ví dụ: `StrongPass@123` trong môi trường dev)

Các lệnh hay dùng khi thao tác EF Core:
```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

Nếu máy báo lỗi `dotnet-ef not found`, cài tool global:
```bash
dotnet tool install --global dotnet-ef
```

## ✅ Lưu ý cho developer
- Không commit các thư mục `bin/` và `obj/` — đã có trong `.gitignore`.
- Không lưu mật khẩu thật vào `appsettings.json` trong repo; sử dụng secrets hoặc biến môi trường cho môi trường production.
- Kiểm tra `appsettings.Development.json` để biết cấu hình dành cho môi trường dev.

## 📚 Tài liệu tham khảo
- Entity Framework: https://learn.microsoft.com/ef
- ASP.NET Core: https://learn.microsoft.com/aspnet/core

---
Nếu cần, tôi có thể giúp: chuẩn hoá `launchSettings.json`, thêm hướng dẫn debug trong VS Code, hoặc tạo script docker-compose cho dev. 
````