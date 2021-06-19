# quanlynhasach

chưa tìm được host free SQL server nên tạm thời thao tác trên máy cá nhân qua các bước:
1. Chạy query QLNS.sql bằng SSMS
2. Trong Visual Studio, nhấn tổ hợp phím Ctrl + Alt + S
3. Ở cửa sổ hiện ra chọn nút Connect to Database
4. Thông tin ở ô Server name sẽ ứng với ô Server name của cửa sổ Connect to Server khi vừa bật SSMS
5. Ở ô Select or enter a database name, chọn database QLNS
6. Bấm Ok

!!! Thay đổi cách connect server
1. Bật file Program.cs
2. Tại biến ServerPath của class Globals, thay đổi đường dẫn đến thư mục server
3. Chạy bình thường

