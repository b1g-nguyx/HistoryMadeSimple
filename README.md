chỉ được tạo pull request không được tự ý merge 

các bước dùng git : git pull (ở nhanh develop) tạo nhánh mời từ develop -> code -> commit -> checkout qua develop -> pull về -> checkout qua nhanh đã commit ( nhánh vừa code ) -> merge develop vào nhánh đó -> xủ lý conflict -> đẩy nhánh đó lên repo -> tạo pull request tời develop -> copy link develop gửi vào nhóm ( bích sẽ merge vào develop sau khi check) 

chỉ được commit những file của mình làm ( chú ý tới appsetting.json không được tự ý sửa nếu có sửa cần phải báo lại tránh trường hợp lỗi xẩy ra do cấu hình của từng thành viên khác nhau)


các nhanh bao gồm :
1. masster: Nhánh chính dùng để chứa phiên bản ổn định nhất của dự án
2. develop: Nhánh phát triển (develop) 
3. feature: Nhánh tính năng
4. hotfix/: sửa lỗi trên bản đang chạy (production).
5. bugfix/: sửa lỗi đang phát triển.
6. release: Nhánh phát hành
