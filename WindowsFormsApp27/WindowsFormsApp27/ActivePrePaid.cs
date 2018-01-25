using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class ActivePrePaid
    {
        private List<Ticket> PrePaidTickets = new List<Ticket>();

        //Constructors
        public ActivePrePaid()
        {

        }

        //Methods
        public List<Ticket> GetTickets()
        {
            return PrePaidTickets;
        }

        public void AddTicket()
        {
            Ticket ticket = new Ticket();
            PrePaidTickets.Add(ticket);
        }

        public bool PayTicket(int ticketNo)
        {
            foreach (Ticket ticket in PrePaidTickets)
            {
                if (ticket.GetHashCode() == ticketNo && !ticket.IsPaid())
                {
                    ticket.SetPaid(true);
                    return true;
                }
            }
            return false;
        }

        public bool InCarPark(int ticketNo)
        {
            foreach (Ticket ticket in PrePaidTickets)
            {
                if (ticket.GetHashCode() == ticketNo && !ticket.InCarPark())
                { 
                    ticket.SetInCarPark(true);
                    return true;
                }
            }
            return false;
        }

        public void RemoveTicket(int ticketNo)
        {
            foreach (Ticket ticket in PrePaidTickets)
            {
                if (ticket.GetHashCode() == ticketNo)
                {
                    PrePaidTickets.Remove(ticket);
                    return;
                }
            }
        }

        public bool CheckTicket(int ticketNo)
        {
            foreach (Ticket ticket in PrePaidTickets)
            {
                if (ticket.GetHashCode() == ticketNo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}