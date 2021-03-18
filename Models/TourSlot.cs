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
        public DateTime TimeInfo { get; set; }
        [Required]
        public bool Available { get; set; } = true;

        public void UpdateAvailablity()
        {
            Available = false;
        }

    }

    

}
