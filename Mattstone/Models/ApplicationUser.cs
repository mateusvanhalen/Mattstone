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

        [Required]
        [Display(Name = "Family")]
        public Family Family { get; set; }

        [Required]
        public int FamilyId { get; set; }
        
    }
}
