using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Mattstone.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mattstone.Models.ViewModels
{
    public class ChoresEditViewModel
    {
        public Chore Chore { get; set; }
        public List<SelectListItem> Day { get; set; }
        public List<SelectListItem> Users { get; set; }
        public bool IsParent { get; set; }

        public ChoresEditViewModel()
        {}
        public ChoresEditViewModel(ApplicationDbContext context)
        {
            //this makes each day into a SelectListItem object
            Day = context.Day.Select(li => new SelectListItem()
            {
                Text = li.DayName,
                Value = li.DayId.ToString()
            }).ToList();

            Users = context.ApplicationUser.Select(li => new SelectListItem()
            {
                Text = li.UserHandle,
                Value = li.Id.ToString()
            }).ToList();
        }
    }
}