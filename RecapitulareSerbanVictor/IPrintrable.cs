using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareSerbanVictor
{
    interface IPrintable
    {
        void Print();
    }

    class StudentPrintable : IPrintable
    {
        public string Nume { get; set; }
        public double Medie { get; set; }

        public StudentPrintable(string nume, double medie)
        {
            Nume = nume;
            Medie = medie;
        }

        public void Print()
        {
            Console.WriteLine($"Student: {Nume}, Medie: {Medie}");
        }
    }

}
