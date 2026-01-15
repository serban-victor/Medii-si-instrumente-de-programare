using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor
{
    public class Caine : Animal
    {
        public Caine(string nume) : base(nume) { }

        public override void Vorbeste()
        {
            Console.WriteLine($"{Nume} latră");
        }
    }
}
