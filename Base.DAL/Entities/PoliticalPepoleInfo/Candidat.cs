using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Candidat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ElectionId")]
        public int ElectionId { get; set; }

        [Required]
        [ForeignKey("PoliticianId")]
        public int PoliticianId { get; set; }
    }
}