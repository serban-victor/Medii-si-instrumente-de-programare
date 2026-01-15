using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor
{
    public class ContBancar
    {
        //incapsulare
        private double sold;
        public double Sold
        {
            get { return sold; }
            private set { sold = value; }
        }

        public static int NumarConturi = 0;

        public ContBancar(double soldInitial)
        {
            sold = soldInitial;
            NumarConturi++;
        }

        public void Depune(double suma)
        {
            if (suma > 0)
                sold += suma;
        }

        public void Retrage(double suma)
        {
            if (suma > 0 && suma <= sold)
                sold -= suma;
            else
                Console.WriteLine("Fonduri insuficiente!");
        }

        public void AfiseazaSold()
        {
            Console.WriteLine($"Soldul contului este: {sold}");
        }
    }

}
