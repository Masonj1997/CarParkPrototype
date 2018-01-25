using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class Ticket
    {
        private bool paid = false;
        private bool inCarPark = false;
        public bool IsPaid()
        {
            return paid;
        }

        public bool InCarPark()
        {
            return inCarPark;
        }

        public void SetInCarPark(bool inCarPark)
        {
            this.inCarPark = inCarPark;
        }

        public void SetPaid(bool paid)
        {
            this.paid = paid;
        }
    }
}
