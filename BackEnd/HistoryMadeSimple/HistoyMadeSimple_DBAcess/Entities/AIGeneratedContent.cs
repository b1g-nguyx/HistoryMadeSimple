using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoyMadeSimple_DBAcess.Entities
{
    //AIGeneratedContent: Quản lý nội dung do AI tạo
    [Table("AIGeneratedContent")]
    public class AIGeneratedContent : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? ContentType { get; set; } // Lộ trình, Câu hỏi, Bài viết

        public string? ContentData { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
