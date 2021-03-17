using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models.ViewModels
{
    public class DayOfWeekViewModel
    {
        public IQueryable<TourSlot> Monday { get; set; }
        public IQueryable<TourSlot> Tuesday { get; set; }
        public IQueryable<TourSlot> Wednesday { get; set; }
        public IQueryable<TourSlot> Thursday { get; set; }
        public IQueryable<TourSlot> Friday { get; set; }
        public IQueryable<TourSlot> Saturday { get; set; }
    }
}
