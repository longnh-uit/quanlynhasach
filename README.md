# quanlynhasach

chưa tìm được host free SQL server nên tạm thời thao tác trên máy cá nhân qua các bước:
1. Chạy query QLNS.sql bằng SSMS
2. Trong Visual Studio, nhấn tổ hợp phím Ctrl + Alt + S
3. Ở cửa sổ hiện ra chọn nút Connect to Database
4. Thông tin ở ô Server name sẽ ứng với ô Server name của cửa sổ Connect to Server khi vừa bật SSMS
5. Ở ô Select or enter a database name, chọn database QLNS
6. Bấm Ok
7. Ở cửa sổ Server Explorer, chuột phải vào database chọn properties
8. Ở của sổ Properties (nếu chưa hiện ra thì chờ một lúc), copy giá trị của Connection String
9. Bật source code của frmLogin lên, paste giá trị vừa copy vào tham trị của SqlConnection ở phần Create connection to database
