using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;

namespace RecapitulareSerbanVictor.Capstone
{
    public class StudentRepository
    {
        private List<StudentCapstone> studenti = new List<StudentCapstone>();

        public void AdaugaStudent(StudentCapstone s) => studenti.Add(s);

        public void StergeStudent(string nume)
        {
            var student = studenti.FirstOrDefault(s => s.Nume == nume);
            if (student != null)
                studenti.Remove(student);
        }

        public IEnumerable<StudentCapstone> TotiStudentii() => studenti;

        public IEnumerable<StudentCapstone> StudentiiPromovati() => studenti.Where(s => s.EstePromovat());

        public double MediaGenerala() => studenti.Any() ? studenti.Average(s => s.Medie) : 0;

        public int NumarPromovati() => studenti.Count(s => s.EstePromovat());
    }
}

