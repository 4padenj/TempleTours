using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class ReservationsContext:DbContext
    {
        public ReservationsContext(DbContextOptions<ReservationsContext> options): base(options)
        {

        }
        public DbSet<TourSlot> TourSlots { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
