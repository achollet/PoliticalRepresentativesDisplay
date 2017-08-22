using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.DAL.Entities
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(2)]
        public string CodeIso2 { get; set; }

        [Required]
        [MaxLength(3)]
        public string CodeIso3 { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public IEnumerable<Region> Regions { get; set; }
    }
}