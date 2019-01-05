using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mattstone.Data;

namespace Mattstone.Models.ViewModels
{
    public class ChoreIndexViewModel
    {
        public List<Chore> Chores { get; set; }
        public bool IsParent { get; set; }
        public int FamilyId { get; set; }
        }
    }