using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor.Capstone
{
    public class StudentCapstone
    {
        public string Nume { get; set; }
        private double medie;

        public double Medie
        {
            get => medie;
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Media trebuie sa fie intre 0 si 10");
                medie = value;
            }
        }

        public StudentCapstone(string nume, double medie)
        {
            Nume = nume;
            Medie = medie;
        }

        public void Afiseaza()
        {
            Console.WriteLine($"Student: {Nume}, Medie: {Medie}");
        }

        public bool EstePromovat() => Medie >= 5;
    }
}

