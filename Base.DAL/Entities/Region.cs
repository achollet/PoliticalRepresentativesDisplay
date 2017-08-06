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
        public int Code { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Acronym { get; set; }
        public bool IsDomTom { get; set; }
        public virtual ICollection<Department> Depatments { get; set; }
    }
}