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
        public int ElectionRound { get; set; }

        [Required]
        public long NumberOfVoices { get; set; }

        [Required]
        [ForeignKey("ElectionId")]
        public int ElectionId { get; set; }

        [Required]
        [ForeignKey("TownId")]
        public int TownId { get; set; }

        [Required]
        [ForeignKey("CandidatId")]
        public int CandidatId { get; set; }
    }
}