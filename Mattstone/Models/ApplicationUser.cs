using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Mattstone.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Family Role")]
        public string FamilyRole { get; set; }

        [Display(Name = "Family")]
        public Family Family { get; set; }

        [Display(Name = "User Name optional")]
        public string UserHandle { get; set; }

        [Display(Name = "Are you a parent?")]
        public bool IsParent { get; set; }

        public int? FamilyId { get; set; }

        public virtual ICollection<Chore> Chore { get; set; }

    }
}
