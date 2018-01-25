using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class CarPark
    {
        //Attributes
        private int currentSpaces;
        private int currentPrePaidSpaces;
        private int maxPrePaid = 5;
        private int maxSpace = 5;
        private int emergVehicleNo = 0;
        private EntrySensor entry;
        private TicketMachine ticketMachine;
        private TicketValidator ticketValidator;
        private FullSign fullSign;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        public bool emergency = false;

        //Constructor
        public CarPark(TicketMachine ticketMachine, TicketValidator ticketValidator, FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
            currentSpaces = maxSpace;
            currentPrePaidSpaces = maxPrePaid;
            this.entry = new EntrySensor(this);
        }

        //Methods
        public void IsEmergency()
        {

            if (emergency == false)
            { emergency = true; }
            else if (emergency == true)
            { emergency = false; }
        }

        public void CarArrivedAtEntrance()
        {
            ticketMachine.CarArrived();
        }

        public void TicketDispensed()
        {
            entryBarrier.Raise();
        }

        public void EmergencyEntry()
        {
            entryBarrier.Raise();
        }

        public void CarEnteredCarPark()
        {
            if (!emergency)
                currentSpaces--;
            else
                emergVehicleNo++;
            if (currentSpaces == 0)
                fullSign.SetLit(true);
            else
                fullSign.SetLit(false);
            entryBarrier.Lower();
            ticketMachine.ClearMessage();
        }

        public void CarArrivedAtExit()
        {
            if(!emergency)
                ticketValidator.CarArrived();

        }

        public void TicketValidated()
        {
            exitBarrier.Raise();
        }

        public void CarExitedCarPark()
        {
            if (!emergency)
            {
                fullSign.SetLit(false);
                exitBarrier.Lower();
                ticketValidator.ClearMessage();
                currentSpaces++;
            }
            else
            {
                emergVehicleNo--;
                exitBarrier.Lower();
            }
        }

        public bool IsFull()
        {
            if (currentSpaces == 0)
                return true;
            else
                return false;
        }

        public bool IsEmpty()
        {
            if (currentSpaces == maxSpace)
                return true;
            else
                return false;
        }

        public bool HasSpace()
        {
            if (currentSpaces > 0)
                return true;
            else
                return false;
        }

        public int GetCurrentSpaces()
        {
            return currentSpaces;
        }
        public int GetMaxSpaces()
        {
            return maxSpace;
        }
        public int GetCurrentPrePaidSpaces()
        {
            return currentPrePaidSpaces;
        }
        public int GetMaxPrePaidSpaces()
        {
            return maxPrePaid;
        }
        public int GetNoEmergVehicles()
        {
            return emergVehicleNo;
        }
    }
}
