using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovayaaaaa
{
    public class TicketDataContext : DbContext
    {
        public TicketDataContext() : base("DbConnectionString") { }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
