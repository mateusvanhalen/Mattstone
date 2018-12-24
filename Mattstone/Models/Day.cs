﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Mattstone.Models
{
    public class Day
    {
        [Key]
        [Required]
        public int DayId { get; set; }
        [Required]
        public string DayName { get; set; }
        public virtual Chore Chore { get; set; }
        public virtual ICollection<ApplicationUser> User { get; set; }
    }
}
