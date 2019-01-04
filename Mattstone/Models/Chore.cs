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

        public string UserId { get; set; }
        
        public bool Done { get; set; }

        public int DayId { get; set; }
        
        public virtual Day Day { get; set; }

        public string UserHandle { get; set; }
    }
}
