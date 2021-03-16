using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class ReservationsDbContext:DbContext
    {
        public ReservationsDbContext(DbContextOptions<ReservationsDbContext> options): base(options)
        {

        }
        public DbSet<TourSlot> TourSlots { get; set; }
        
        public DbSet<Reservation> Reservations { get; set; }
        // public DbSet<Time> Times { get; set; }
    }
}
