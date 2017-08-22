using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class District
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Label { get; set; }
        
        [Required]
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public IEnumerable<Town> Towns { get; set; }
    }
}