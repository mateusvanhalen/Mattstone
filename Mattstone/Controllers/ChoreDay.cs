using Mattstone.Models;
using System.ComponentModel.DataAnnotations;

namespace Mattstone.Controllers
{
    internal class ChoreDay
    {
        [Key]
        public int ChoreDayId { get; set; }
        [Required]
        public int ChoreId { get; set; }
        [Required]
        public int DayId { get; set; }

        public Chore Chore { get; set; }
        public Day Day { get; set; }
    }
}