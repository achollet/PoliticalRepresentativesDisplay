using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Region
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CodeInsee { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        
        [MaxLength(6)]
        public string CodeIso { get; set; }
        
        [Required]
        public bool IsNew { get; set; }
        
        [Required]
        public bool IsOversea { get; set; }

        [Required]
        [ForeignKey("CountryId")]
        public int CountryId { get; set; }
        public IEnumerable<Department> Departments { get; set; }     
    }
}