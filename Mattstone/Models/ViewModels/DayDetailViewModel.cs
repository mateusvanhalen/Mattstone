using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattstone.Models.ViewModels
{
    public class DayDetailViewModel
    {
        public Day Day { get; set; }
        public ApplicationUser Users { get; set; }
        public List<Chore> Chores { get; set; }
    }
}
