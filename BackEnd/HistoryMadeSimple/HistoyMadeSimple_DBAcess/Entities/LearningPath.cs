using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoyMadeSimple_DBAcess.Entities
{
    //LearningPaths: Quản lý lộ trình học tập của người dùng
    [Table("LearningPaths")]
    public class LearningPath : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserID { get; set; } // Liên kết với Users

        [Required]
        [MaxLength(200)]
        public string? PathName { get; set; }

        public string? Description { get; set; }

        [ForeignKey("UserID")]
        public User? User { get; set; }

        public ICollection<LearningPathLesson>? LearningPathLessons { get; set; }
    }
}
