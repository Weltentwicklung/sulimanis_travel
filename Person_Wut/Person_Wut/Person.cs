using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Wut
{
    internal class Person
    { // können wir so alleine nicht machen, weil wir noch properties zu gelassenheit und schlafmangel machen müssten oder diese durch die anderen Properties verändern.
        private int gelassenheit;
        private int schlafmangel;

        public (int Qualität, int Quantität) Zuhören { get; set; }

        public (int Menge, int Schwierigkeitsgrad) Hausaufgaben { get; set; }

        public int Schlafe
        {
            set { var quantität = value; }

        }

        public int Wut { 
        get {
                return 50 - gelassenheit * schlafmangel;
                    }
        }
     
    }
}
