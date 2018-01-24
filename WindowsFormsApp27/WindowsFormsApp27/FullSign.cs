using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class FullSign
    {
        //Attributes
        private bool lit;

        //Constructors
        public FullSign()
        {
            lit = false;
        }

        //Methods
        public bool IsLit()
        {
            return lit;
        }

        public void SetLit(bool lit)
        {
            this.lit = lit;
        }
    }
}
