using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Affiliation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AdhesionDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime LeavingDate { get; set; }

        [Required]
        [ForeignKey("PoliticalPartyId")]
        public int PoliticalPartyId { get; set; }

        [Required]
        [ForeignKey("PoliticalIdId")]
        public int PoliticalId { get; set; }
    }
}