using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Term
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        
        [Required]
        public int TermType { get; set; }
        
        [Required]
        [ForeignKey("CandidatId")]
        public int CandidatId { get; set; }
        
        [Required]
        [ForeignKey("ElectionId")]
        public int ElectionId { get; set; }
    }
}