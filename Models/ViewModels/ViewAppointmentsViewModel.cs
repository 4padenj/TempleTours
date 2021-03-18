using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models.ViewModels
{
    public class ViewAppointmentsViewModel
    {
        public IQueryable<Reservation> Monday { get; set; }
        public IQueryable<Reservation> Tuesday { get; set; }
        public IQueryable<Reservation> Wednesday { get; set; }
        public IQueryable<Reservation> Thursday { get; set; }
        public IQueryable<Reservation> Friday { get; set; }
        public IQueryable<Reservation> Saturday { get; set; }
    }
}
