using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoyMadeSimple_DBAcess.Entities
{
    //Regions: Quản lý khu vực địa lý
    [Table("Regions")]
    public class Region : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string RegionName { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }

        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
        public ICollection<HistoricalSite> HistoricalSites { get; set; } = new List<HistoricalSite>();
    }
}
