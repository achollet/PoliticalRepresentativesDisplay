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
        [MaxLength(250)]
        public string Name { get; set; }
        
        [MaxLength(25)]
        public string Acronym { get; set; }
        
        [Required]
        public bool IsNew { get; set; }
        
        [Required]
        public bool IsOversea { get; set; }
        //public List<Department> Departments { get; set; }     
    }
}