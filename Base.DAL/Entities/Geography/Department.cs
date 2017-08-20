using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(5)]
        public string Code { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        
        [Required]
        [ForeignKey("RegionId")]
        public int RegionId { get; set; }
        public List<District> Districts { get; set; }
        public List<Town> Towns { get; set; }
    }
}