using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor
{
    public class Pisica : Animal
    {
        public Pisica(string nume) : base(nume) { }

        public override void Vorbeste()
        {
            Console.WriteLine($"{Nume} miaună");
        }
    }
}
