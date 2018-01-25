using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class TicketValidator
    {
        private string message;
        private ActiveTickets activeTickets;
        private ActivePrePaid activePrePaidTickets;
        private CarPark carPark;

        public TicketValidator(ActiveTickets activeTickets, ActivePrePaid activePrePaidTickets)
        {            
            this.activeTickets = activeTickets;
            this.activePrePaidTickets = activePrePaidTickets;
        }
        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please insert your ticket.";
        }

        public bool TicketEntered()
        {
            if (activeTickets.GetTickets()[0].IsPaid())
            {
                message = "Thank you, drive safely.";
                activeTickets.RemoveTicket();
                return true;
            }
            else
            {
                message = "Error: Ticket not paid for!";
                return false;
            }

        }

        public void PrePaidCodeEntered(int ticketNo)
        {
            activePrePaidTickets.RemoveTicket(ticketNo);
        }

        public bool EnterPrePaidCode(int ticketNo)
        {
            return activePrePaidTickets.CheckTicket(ticketNo);
        }
        public bool PayTicket(int ticketNo)
        {
            return activeTickets.PayTicket(ticketNo) || activePrePaidTickets.PayTicket(ticketNo);
        }

        public void ClearMessage()
        {
            message = "";
        }

        public string GetMessage()
        {
            return message;
        }
    }
}
