using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Mattstone.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattstone.Models.ViewModels
{
    public class ChoresCreateViewModel
    {
        private ApplicationDbContext _context;

        public ChoresCreateViewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Chore Chore { get; set; }
        public ICollection<SelectListItem> Day { get; set; }
    }
}
