using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattstone.Models.ViewModels
{
    public class FamilyDetialViewModel
    {
        public Family Family { get; set; }
        public List<ApplicationUser> Users { get; set; }
        public ApplicationUser User { get; set; }
        public bool IsParent { get; set; }
    }
}
