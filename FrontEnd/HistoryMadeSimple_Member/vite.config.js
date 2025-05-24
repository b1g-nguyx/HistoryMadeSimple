import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vite.dev/config/
export default defineConfig({
  plugins: [react()],
   server: {
    host: 'localhost',   // hoặc có thể '0.0.0.0' nếu muốn truy cập từ mạng LAN
    port: 5555,          // port bạn muốn, ví dụ 3000, 5000, 5173,...
    open: true,          // tự động mở trình duyệt khi chạy dev server
  },
})
