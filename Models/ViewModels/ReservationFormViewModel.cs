using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models.ViewModels
{
    public class ReservationFormViewModel
    {
        public TourSlot Tour { get; set; }

        public Reservation Reservation { get; set; }
    }
}
