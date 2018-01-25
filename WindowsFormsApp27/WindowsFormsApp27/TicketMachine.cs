using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class TicketMachine
    {
        private string message;
        private CarPark carPark;
        private ActiveTickets activeTickets;
        private ActivePrePaid activePrePaidTickets;

        public TicketMachine(ActiveTickets activeTickets, ActivePrePaid activePrePaidTickets)
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
            if (carPark.emergency == false)
                message = "Please press to get a ticket.";
        }
        public void SpacesMessage()
        {
            message = "Please park in space: " + Convert.ToString((carPark.GetMaxSpaces() - carPark.GetCurrentSpaces()) + 1);
        }
        public void PrintTicket()
        {
            
            activeTickets.AddTicket();
            carPark.TicketDispensed(); 
        }

        public void PrePaidChecked()
        {
            message = "Please park on floor 2 in space: " + Convert.ToString((carPark.GetMaxPrePaidSpaces() - carPark.GetCurrentPrePaidSpaces()) + 1);
            carPark.PrePaidChecked();
        }

        public void PrintPrePaidTicket()
        {
            activePrePaidTickets.AddTicket();
            carPark.AddPrePaidTicket();
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

