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
        [Required]
        public bool Available { get; set; } = true;
        
    }

    // PADEN's ATTEMPT TO LOGIC HIS WAY THROUGH... I want to come back to this, but I ran out of time.
    //public class Time {
    //    public Time()
    //    {
    //        for (int i=8; i<=21; i++)
    //        {

    //            string timeName = i + ":00";

    //        }
    //    }


    //    [Key]
    //    public int TimeID { get; set; }
    //    [Required]
    //    public string TimeName { get; set; }
    //    [Required]
    //    //Sets an available time
    //    public bool Available { get; set; } = true;

    //    // Creates a list of times
    //    public static List<Time> times = new List<Time>();
    //    // Enumerates the times
    //    public static IEnumerable<Time> Times => times;
    //    // Creates the ability to add to the list of times
    //    public static void AddTime(Time t)
    //    {
    //        times.Add(t);
    //    }
    //}

}
