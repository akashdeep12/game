using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sohi_russian
{
    class spinner
    {
       public int loadchamber;
        public int spinchamer;
        public string  name;

        public int reset;
        public int spin_bullete(int spinchamer)//this the spin_bullete method
        {
            if (spinchamer == 6)
            {
                spinchamer = 1;
            }
            else
            {
                spinchamer++;
            }
            return spinchamer;
        }
    }
}
