chỉ tại pull request không được tự ý merge 

các bước dùng git : git pull (ở nhanh develop) tạo nhánh mời từ develop -> code -> commit -> checkout qua develop -> pull về -> checkout qua nhanh đã commit ( nhánh vừa code ) -> merge develop vào nhánh đó -> xủ lý conflict -> đẩy nhánh đó lên repo -> tạo pull request tời develop -> copy link develop gửi vào nhóm ( bích sẽ merge vào develop sau khi check) 

chỉ được commit những file của mình làm ( chú ý tới appsetting.json không được tự ý sửa nếu có sửa cần phải báo lại tránh trường hợp lỗi xẩy ra do cấu hình của từng thành viên khác nhau)

