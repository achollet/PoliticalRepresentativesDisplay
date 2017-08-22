using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Election
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ElectionTypeId")]
        public int ElectionTypeId { get; set; }

        [Required]
        public bool IsLocal { get; set; }
        
        public IEnumerable<Candidature> Candidatures { get; set; }
        public IEnumerable<ElectionResult> ElectionResults { get; set; }
    }
}