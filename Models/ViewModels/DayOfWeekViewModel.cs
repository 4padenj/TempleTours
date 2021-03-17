using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models.ViewModels
{
    public class DayOfWeekViewModel
    {
        public IEnumerable<TourSlot> Monday { get; set; }
        public IEnumerable<TourSlot> Tuesday { get; set; }
        public IEnumerable<TourSlot> Wednesday { get; set; }
        public IEnumerable<TourSlot> Thursday { get; set; }
        public IEnumerable<TourSlot> Friday { get; set; }
        public IEnumerable<TourSlot> Saturday { get; set; }
    }
}
