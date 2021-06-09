using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaaaaa
{
    public partial class FlightAddition : Form
    {
        public FlightAddition()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (inputArrivalPoint != null && inputDeparturePoint != null && inputDateTime != null)
            {
                string departurePoint = inputDeparturePoint.Text;
                string arrivalPoint = inputArrivalPoint.Text;
                DateTime dateTime = DateTime.Parse(inputDateTime.Text);

                using (var context = new TicketDataContext())
                {
                    var flight = new Flight()
                    {
                        DeparturePoint = departurePoint,
                        ArrivalPoint = arrivalPoint,
                        Time = dateTime
                    };

                    context.Flights.Add(flight);
                    context.SaveChanges();
                }
            }

            Close();
        }
    }
}
