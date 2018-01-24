﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class TicketMachine
    {
        private string message;
        //private EntrySensor entry;
        private ActiveTickets activeTickets;
        private CarPark carPark;

        public TicketMachine(ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please press to get a ticket.";
        }

        public void PrintTicket()
        {
            message = "Thank you, enjoy your stay.";
            activeTickets.AddTicket();
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
