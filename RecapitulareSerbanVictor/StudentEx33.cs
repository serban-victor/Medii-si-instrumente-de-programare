using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor
{
    class StudentEx33
    {
        private string nume;
        private double medie;

        //validare
        public string Nume
        {
            get { return nume; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Numele nu poate fi gol. Se seteaza 'Anonim'.");
                    nume = "Anonim";
                }
                else
                {
                    nume = value;
                }
            }
        }

        public double Medie
        {
            get { return medie; }
            set
            {
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("Media trebuie sa fie intre 0 si 10. Se seteaza 0.");
                    medie = 0;
                }
                else
                {
                    medie = value;
                }
            }
        }
        public StudentEx33(string nume, double medie)
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
