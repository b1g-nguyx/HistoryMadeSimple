using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoyMadeSimple_DBAcess.Entities
{
    //BlogPosts: Quản lý bài viết blog
    [Table("BlogPosts")]
    public class BlogPost : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(450)]
        public string? UserId { get; set; } // Liên kết với ApplicationUser (cả Admin và User đều có thể viết blog)

        [Required]
        [MaxLength(200)]
        public string? Title { get; set; }

        public string? Content { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }
    }
}
