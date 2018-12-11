using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mattstone.Models
{
    public class Family
    {
        [Key]
        [Required]
        public int FamilyId { get; set; }
        [Required]
        public string FamilyName { get; set; }
    }
}
