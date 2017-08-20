using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Candidature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ElectionResultId")]
        public int ElectionResultId { get; set; }

        [Required]
        [ForeignKey("PoliticianId")]
        public int PoliticianId { get; set; }
    }
}