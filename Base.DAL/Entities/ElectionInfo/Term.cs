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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]        
        public DateTime StartingDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndingDate { get; set; }
        
        [Required]
        [ForeignKey("TermTypeId")]
        public int TermTypeId { get; set; }

        [Required]
        [ForeignKey("ElectionId")]
        public int ElectionId { get; set; }
        
        [Required]
        [ForeignKey("PoliticianId")]
        public int PoliticianId { get; set; }
    }
}