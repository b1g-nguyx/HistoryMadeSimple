using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoyMadeSimple_DBAcess.Entities
{
    //SupportTickets: Quản lý hỏi đáp
    [Table("SupportTickets")]
    public class SupportTicket : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserID { get; set; } // Liên kết với Users

        [Required]
        [MaxLength(200)]
        public string? Title { get; set; }

        public string? Content { get; set; }

        [MaxLength(20)]
        public string? Status { get; set; } // Mở, Đang xử lý, Đóng

        [ForeignKey("UserID")]
        public User? User { get; set; }
    }
}
