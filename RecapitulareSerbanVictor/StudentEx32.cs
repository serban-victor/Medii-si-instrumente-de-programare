using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor
{
    internal class StudentEx32
    {
        public string Nume { get; set; }
        public double Medie { get; set; }

        public StudentEx32()
        {
            Nume = "Anonim";
            Medie = 0;
        }

        public StudentEx32(string nume, double medie)
        {
            Nume = nume;
            Medie = medie;
        }

        public void Afiseaza()
        {
            Console.WriteLine($"Student: {Nume}, Medie: {Medie}");
        }
    }
}
