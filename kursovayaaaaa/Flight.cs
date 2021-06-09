using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovayaaaaa
{
    public class Flight
    {
        public int Id { get; set; }
        public string DeparturePoint { get; set; }
        public string ArrivalPoint { get; set; }
        public DateTime Time { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
