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
    public partial class ModeratorPanel : Form
    {
        private List<int> _flightIds = new List<int>();
        private List<int> _ticketIds = new List<int>();

        public ModeratorPanel()
        {
            InitializeComponent();
        }

        private void ModeratorPanel_Load(object sender, EventArgs e)
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

        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputPrice.Text, out int cost))
            {
                using (var context = new TicketDataContext())
                {
                    var ticket = new Ticket()
                    {
                        FlightId = _flightIds[listBoxFlights.SelectedIndex],
                        Cost = cost,
                        IsBought = false
                    };

                    context.Tickets.Add(ticket);
                    context.SaveChanges();
                    string dataToAdd = $"Price: {ticket.Cost}";
                    listBoxTickets?.Invoke(new Action(() => listBoxTickets.Items.Add(dataToAdd)));
                    listBoxTickets?.Invoke(new Action(() => listBoxTickets.Update()));
                }
            }
        }

        private void buttonRemoveTicket_Click(object sender, EventArgs e)
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
                        context.Tickets.Remove(selectedTicket);

                        context.SaveChanges();
                        listBoxTickets.Items.RemoveAt(listBoxTickets.SelectedIndex);
                    }
                }
            }
        }

        private void inputPrice_Click(object sender, EventArgs e)
        {
            inputPrice.Text = string.Empty;
        }

        private void buttonAddFlight_Click(object sender, EventArgs e)
        {
            new FlightAddition().ShowDialog();
        }

        private void buttonRemoveFlight_Click(object sender, EventArgs e)
        {
            if (listBoxFlights.SelectedItem != null)
            {
                int currentFlightId = _flightIds[listBoxFlights.SelectedIndex];

                using (var context = new TicketDataContext())
                {
                    var tickets = context.Tickets.Where(ticket => ticket.FlightId == currentFlightId);
                    var flights = context.Flights.Where(flight => flight.Id == currentFlightId);

                    context.Tickets.RemoveRange(tickets);
                    context.Flights.Remove(flights.First());
                    context.SaveChanges();

                    listBoxFlights.Items.RemoveAt(listBoxFlights.SelectedIndex);
                    listBoxTickets.Items.Clear();
                }
            }
        }

        private void ModeratorPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }
    }
}
