using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovayaaaaa
{
    public class Ticket
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public float Cost { get; set; }
        public bool IsBought { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
