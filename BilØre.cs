using System;
using billetlibrary_Rovsneglen;
namespace oresundbilletlibrary_Rovsneglen
{
    public class BilØre: Bil
    {
        public BilØre()
        {
            
        }

        public override double Pris(bool Brobizz)
        {
            double price = 410;
            if (Brobizz)
                price = 161;

            return price;

        }

        public override string køretøj()
        {
            return "Øresund Bil";
        }

    }
}
