using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class TourSlot
    {
        [Key]
        [Required]
        public int TourSlotID { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string DayOfWeek { get; set; }
        [Required]
        public string Time { get; set; }
    }
}
