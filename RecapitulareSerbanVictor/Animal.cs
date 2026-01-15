using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor
{
    public class Animal
    {
        public string Nume { get; set; }

        public Animal(string nume)
        {
            Nume = nume;
        }

        public virtual void Vorbeste()
        {
            Console.WriteLine($"{Nume} scoate un sunet.");
        }
    }
}
