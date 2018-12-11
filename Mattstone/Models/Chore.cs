using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mattstone.Models
{
    public class Chore
    {
        [Key]
        [Required]
        public int ChoreId { get; set; }
        [Required]
        public string ChoreName { get; set; }
        [Required]
        public string Description { get; set; }
        
        public ApplicationUser User { get; set; }
        [Required]
        public bool Done { get; set; }
        [Required]
        public Day Day { get; set; }
    }
}
