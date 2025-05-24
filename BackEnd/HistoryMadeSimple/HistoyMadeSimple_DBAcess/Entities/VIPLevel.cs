using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoyMadeSimple_DBAcess.Entities
{
    //VIPLevels: Quản lý các cấp độ VIP
    [Table("VIPLevels")]
    public class VIPLevel : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LevelName { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
