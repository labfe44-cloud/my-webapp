# 🚀 Xuan Phu Platform — Hướng dẫn môi trường phát triển

Dự án Xuan Phu Platform là nền tảng du lịch được xây dựng bằng **.NET 8 (MVC)**, **SQL Server 2022** và sử dụng **Tailwind CSS** cho phần frontend. Môi trường phát triển được cấu hình để chạy trong **Docker** nhằm đảm bảo tính nhất quán giữa các hệ điều hành.

---

## 📋 Yêu cầu (Prerequisites)

- `.NET 8 SDK` (hoặc phiên bản tương thích với project).
- `Docker` & `docker-compose` (nếu chạy DB trong container).
- `Visual Studio Code` (khuyến nghị) hoặc Visual Studio 2022.
- `Git`.

Gợi ý phát triển: cài extension **Dev Containers** (`ms-vscode-remote.remote-containers`) nếu dùng VS Code.

---

## 🚀 Khởi chạy nhanh (Quick start)

1) Clone repository và mở project:
```bash
git clone <URL-repo>
cd my-webapp
code .
```

2) Mở project trong Dev Container (khuyến nghị): chọn **Reopen in Container** khi VS Code gợi ý, hoặc dùng Command Palette → `Dev Containers: Reopen in Container`.

3) Sau khi vào container (hoặc nếu môi trường đã có .NET 8), chạy migration DB:
```bash
cd src/XuanPhu.Web
dotnet tool restore    # nếu project dùng tool manifest
dotnet ef database update
```

4) Chạy backend:
```bash
cd src/XuanPhu.Web
dotnet watch run
```

5) (Tyyyyyyyyy nếu có frontend build/watch) Chạy frontend watcher:
```bash
cd src/XuanPhu.Web
npm install   # lần đầu
npm run watch
```

6) Mở trình duyệt vào URL hiển thị bởi `dotnet run` (thường là `http://localhost:5000` hoặc `https://localhost:5001`).

---

## 🔧 Cấu hình cơ sở dữ liệu (dev)

Project có cấu hình sử dụng SQL Server chạy trong Docker. Thông tin trong `docker/docker-compose.dev.yml`:

- **Container name**: `dev-sqlserver` (service `sqlserver` trong compose)
 truy cập từ host dùng `localhost,1433`
- **Database**: `XuanPhuDB`
- **User**: `sa`
- **Password (dev)**: `Strong!Pass123` (xem `docker/docker-compose.dev.yml` và `src/XuanPhu.Web/appsettings.Development.json`)

Lệnh EF Core thường dùng:
```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

Nếu nhận được lỗi `dotnet-ef not found`, cài tool:
```bash
dotnet tool install --global dotnet-ef
```

---

## 📁 Cấu trúc thư mục (tóm tắt)

XuanPhuPlatform/                    <-- (Root Workspace(my-webapp))
├── .devcontainer/                  # Cấu hình môi trường Dev cho VS Code
│   └── devcontainer.json
├── .vscode/                        # Cấu hình launch, task cho Editor
│   └── launch.json
├── docker/                         # Các file cấu hình Docker
│   ├── dev.Dockerfile              # Image cho môi trường Dev
│   ├── prod.Dockerfile             # Image tối ưu cho Product (sau này)
│   └── docker-compose.dev.yml
├── src/                            # Mã nguồn chính
│   ├── XuanPhu.Web/                # Project .NET MVC
│   │   ├── Controllers/
│   │   ├── Data/                   # (Nên đổi từ 'data' sang 'Data')
│   │   │   └── AppDbContext.cs
│   │   ├── Models/
│   │   ├── Views/
│   │   ├── wwwroot/                # File tĩnh (CSS, JS, Ảnh)
│   │   ├── appsettings.json
│   │   ├── Program.cs
│   │   └── XuanPhu.Web.csproj
│   ├── XuanPhu.Domain/             # (Dự kiến cho Clean Arch)
│   └── README.md                   # Hướng dẫn chi tiết cho Dev
├── .gitignore                      # File loại trừ git
└── README.md                       # Tài liệu hướng dẫn cài đặt (Onboarding)

---

## ✅ Lưu ý cho developer

- Không commit `bin/` và `obj/` (đã cấu hình trong `.gitignore`).
- Không lưu mật khẩu thật trong `appsettings.json` của repo; dùng biến môi trường hoặc Secret Manager cho production.
- Kiểm tra `appsettings.Development.json` để biết connection string dev (ví dụ dùng `Server=dev-sqlserver,1433;...`).

---
