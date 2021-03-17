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
                            TimeInfo = new DateTime(2021, 3, 22, 8, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 9, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 10, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 11, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 12, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 13, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 14, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 15, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 16, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 17, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 18, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 19, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 22, 20, 0, 0)
                        },
                        // TUESDAY 3/23

                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 8, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 9, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 10, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 11, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 12, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 13, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 14, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 15, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 16, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 17, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 18, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 19, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 23, 20, 0, 0)
                        },
                        // Wednesday
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 8, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 9, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 10, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 11, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 12, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 13, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 14, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 15, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 16, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 17, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 18, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 19, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 24, 20, 0, 0)
                        },
                        // Thursday
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 8, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 9, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 10, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 11, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 12, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 13, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 14, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 15, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 16, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 17, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 18, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 19, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 25, 20, 0, 0)
                        },
                        // Friday
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 8, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 9, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 10, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 11, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 12, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 13, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 14, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 15, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 16, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 17, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 18, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 19, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 26, 20, 0, 0)
                        },
                        // Saturday
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 8, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 9, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 10, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 11, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 12, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 13, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 14, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 15, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 16, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 17, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 18, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 19, 0, 0)
                        },
                        new TourSlot
                        {
                            TimeInfo = new DateTime(2021, 3, 27, 20, 0, 0)
                        }
                );
                context.SaveChanges();
            }
        }
        
    }
}
