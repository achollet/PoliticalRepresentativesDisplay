using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Town
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string CodeInsee { get; set; }

        [Required]
        public string ZipCode { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("DistrictId")]
        public int DistrictId { get; set; }

        [ForeignKey("TownTypeId")]
        public int TownTypeId { get; set; }
    }
}