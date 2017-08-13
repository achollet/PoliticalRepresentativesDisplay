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
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }
        
        [MaxLength(5)]
        public string InseeCode { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("TownTypeId")]
        public int TownTypeId { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        
        [ForeignKey("DistrictId")]
        public int DistrictId { get; set; }
    }
}