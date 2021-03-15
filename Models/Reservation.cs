using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class Reservation
    {
        [Key]
        [Required]
        public int ReservationID { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        [Required]
        public TourSlot Time { get; set; }

        

    }
}
