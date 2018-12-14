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
        
        public bool Done { get; set; }
        
        public Day Day { get; set; }
    }
}
