using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class ElectionResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Range(1,2)]
        public int Round { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        public long NumberOfVoices { get; set; }

        [Required]
        [ForeignKey("ElectionId")]
        public int ElectionId { get; set; }
        
        [Required]
        [ForeignKey("TownId")]
        public int TownId { get; set; }
        
        [Required]
        [ForeignKey("CandidatureId")]
        public int CandidatureId { get; set; }
    }
}