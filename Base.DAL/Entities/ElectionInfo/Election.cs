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
        public List<Candidature> Candidatures { get; set; }
    }
}