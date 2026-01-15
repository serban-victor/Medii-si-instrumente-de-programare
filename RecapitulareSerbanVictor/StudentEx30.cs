using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor
{
    internal class StudentEx30
    {
        private string nume;
        private double medie;
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public double Medie
        {
            get { return medie; }
            set { medie = value; }
        }

        public void Afiseaza()
        {
            Console.WriteLine($"Student: {Nume}, Medie: {Medie}");
        }
    }
}

