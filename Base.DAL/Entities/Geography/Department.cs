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
        [MaxLength(6)]
        public string CodeIso { get; set; }
        
        [MaxLength(3)]
        public string CodeInsee { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        
        [Required]
        public int NumberOfConstituencies { get; set; }

        [Required]
        [ForeignKey("RegionId")]
        public int RegionId { get; set; }
        public IEnumerable<District> Districts { get; set; }
    }
}