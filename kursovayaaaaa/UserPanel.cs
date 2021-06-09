using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaaaaa
{
    public partial class UserPanel : Form
    {
        private List<int> _flightIds = new List<int>();
        private List<int> _ticketIds = new List<int>();

        public UserPanel()
        {
            InitializeComponent();
        }

        private void buttonSearchWay_Click(object sender, EventArgs e)
        {
            if (inputSearch.Text != string.Empty)
            {
                listBoxFlights.Items.Clear();
                string keySearchString = inputSearch.Text;

                using (var context = new TicketDataContext())
                {
                    var flights = context.Flights.Where(flight => flight.ArrivalPoint.Contains(keySearchString) || flight.DeparturePoint.Contains(keySearchString));

                    foreach (var item in flights)
                    {
                        string dataToAdd = $"Departure Point: {item.DeparturePoint}   ArrivalPoint: {item.ArrivalPoint}   Date Time: {item.Time}";
                        listBoxFlights.Items.Add(dataToAdd);
                    }
                }
            }
            else
            {
                listBoxFlights.Items.Clear();

                using (var context = new TicketDataContext())
                {
                    var flights = context.Flights;

                    foreach (var flight in flights)
                    {
                        string dataToAdd = $"Departure Point: {flight.DeparturePoint}   ArrivalPoint: {flight.ArrivalPoint}   Date Time: {flight.Time}";
                        listBoxFlights.Items.Add(dataToAdd);
                    }
                }
            }
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            List<int> addedFlightsIds = new List<int>();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Run(() =>
                    {
                        using (var context = new TicketDataContext())
                        {
                            var flights = context.Flights;

                            foreach (var flight in flights)
                            {
                                if (!addedFlightsIds.Contains(flight.Id))
                                {
                                    _flightIds.Add(flight.Id);
                                    string dataToAdd = $"Departure Point: {flight.DeparturePoint}   ArrivalPoint: {flight.ArrivalPoint}   Date Time: {flight.Time}";
                                    listBoxFlights?.Invoke(new Action(() => listBoxFlights.Items.Add(dataToAdd)));
                                    listBoxFlights?.Invoke(new Action(() => listBoxFlights.Update()));
                                    addedFlightsIds.Add(flight.Id);
                                }
                            }
                        }
                    });
                }

            });
        }

        private void UserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }

        private void listBoxFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTickets.Items.Clear();

            if (listBoxFlights.SelectedItem != null)
            {
                int currentId = _flightIds[listBoxFlights.SelectedIndex];
                _ticketIds.Clear();

                Task.Run(async () =>
                {
                    await Task.Run(() =>
                    {
                        using (var context = new TicketDataContext())
                        {
                            var flights = context.Flights.Where(flight => flight.Id == currentId);
                            var selectedFlight = flights.FirstOrDefault();

                            foreach (var ticket in selectedFlight.Tickets)
                            {
                                string dataToAdd = $"Price: {ticket.Cost}";
                                listBoxTickets?.Invoke(new Action(() => listBoxTickets.Items.Add(dataToAdd)));
                                listBoxTickets?.Invoke(new Action(() => listBoxTickets.Update()));
                                _ticketIds.Add(ticket.Id);
                            }
                        }
                    });

                });
            }
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            if (listBoxTickets.SelectedItem != null && listBoxFlights.SelectedItem != null)
            {
                int currentFlightId = _flightIds[listBoxFlights.SelectedIndex];
                int currentTicketId = _ticketIds[listBoxTickets.SelectedIndex];
                using (var context = new TicketDataContext())
                {
                    var tickets = context.Tickets.Where(ticket => ticket.FlightId == currentFlightId && ticket.Id == currentTicketId && !ticket.IsBought);

                    if (tickets.Count() > 0)
                    {
                        var selectedTicket = tickets.First();
                        selectedTicket.IsBought = true;

                        context.SaveChanges();
                        new SuccessfullyBuyed().ShowDialog();
                    }
                }
            }
        }
    }
}
