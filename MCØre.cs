using System;
using System.Collections.Generic;
using System.Text;
using billetlibrary_Rovsneglen;

namespace oresundbilletlibrary_Rovsneglen
{
    class MCØre : MC
    {
        public MCØre()
        {
            
        }

        public override double Pris(bool Brobizz)
        {
            double price = 125;
            if (Brobizz)
                price = 73;

            return price;
        }

        public override string køretøj()
        {
            return "Øresund MC";
        }
    }
}
