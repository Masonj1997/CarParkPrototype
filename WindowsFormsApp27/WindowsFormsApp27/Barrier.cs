using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class Barrier
    {
        //Attributes
        private bool lifted = false;

        //Constructors
        public Barrier()
        {

        }

        //Methods
        public void Lower()
        {
            lifted = false;
        }

        public void Raise()
        {
            lifted = true;
        }

        public bool IsLifted()
        {
            return lifted;
        }
    }
}
