using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class PoliticalParty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(150, ErrorMessage="Should not exceed 150 characters")]
        public string Label { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfCreation { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfTermination { get; set; }
    }
}