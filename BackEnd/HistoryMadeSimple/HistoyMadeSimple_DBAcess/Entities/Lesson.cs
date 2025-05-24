using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoyMadeSimple_DBAcess.Entities
{
    //Lessons: Quản lý bài học lịch sử
    [Table("Lessons")]
    public class Lesson : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        public int? RegionID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = null!;

        public string? Content { get; set; }

        [ForeignKey("RegionID")]
        public Region? Region { get; set; }

        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<LessonProgress> LessonProgresses { get; set; } = new List<LessonProgress>();
        public ICollection<LearningPathLesson> LearningPathLessons { get; set; } = new List<LearningPathLesson>();
    }
}
