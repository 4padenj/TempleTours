using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            ReservationsDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ReservationsDbContext>();
            List<TourSlot> tourSlots = new List<TourSlot>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            
            if (!context.TourSlots.Any())
            {
                context.AddRange(
                    // Seed for Monday
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "8:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "9:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "10:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "11:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "12:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "1:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "2:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "3:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "4:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "5:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "6:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "7:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Monday",
                            Date = "3/22",
                            Time = "8:00pm"
                        },
                        //TUESDAY
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "8:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "9:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "10:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "11:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "12:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "1:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "2:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "3:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "4:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "5:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "6:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "7:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Tuesday",
                            Date = "3/23",
                            Time = "8:00pm"
                        },
                        //WEDNESDAY
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "8:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "9:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "10:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "11:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "12:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "1:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "2:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "3:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "4:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "5:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "6:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "7:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Wednesday",
                            Date = "3/24",
                            Time = "8:00pm"
                        },
                        //THURSDAY
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "8:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "9:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "10:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "11:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "12:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "1:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "2:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "3:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "4:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "5:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "6:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "7:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Thursday",
                            Date = "3/25",
                            Time = "8:00pm"
                        },
                        //FRIDAY
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "8:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "9:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "10:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "11:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "12:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "1:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "2:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "3:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "4:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "5:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "6:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "7:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Friday",
                            Date = "3/26",
                            Time = "8:00pm"
                        },
                        //SATURDAY
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "8:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "9:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "10:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "11:00am"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "12:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "1:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "2:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "3:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "4:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "5:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "6:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "7:00pm"
                        },
                        new TourSlot
                        {
                            DayOfWeek = "Saturday",
                            Date = "3/27",
                            Time = "8:00pm"
                        }
                );
                context.SaveChanges();
            }
        }
        
    }
}
