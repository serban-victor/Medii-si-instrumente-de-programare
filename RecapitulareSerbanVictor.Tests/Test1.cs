using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapitulareSerbanVictor.Capstone;
using System;

namespace RecapitulareSerbanVictor.Tests
{
    [TestClass]
    public class StudentCapstoneTests
    {
        [TestMethod]
        public void TestStudentPromovat()
        {
            var student = new StudentCapstone("Ana", 8.5);
            Assert.IsTrue(student.EstePromovat());
        }

        [TestMethod]
        public void TestStudentRespins()
        {
            var student = new StudentCapstone("Alex", 4.0);
            Assert.IsFalse(student.EstePromovat());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMedieInvalidException()
        {
            var student = new StudentCapstone("Ion", 12); // ar trebui să arunce ArgumentException
        }

        [TestMethod]
        public void TestCRUDRepository()
        {
            var repo = new StudentRepository();
            var s1 = new StudentCapstone("Ion", 7.5);
            var s2 = new StudentCapstone("Maria", 9.0);

            repo.AdaugaStudent(s1);
            repo.AdaugaStudent(s2);

            Assert.AreEqual(2, repo.TotiStudentii().Count());

            repo.StergeStudent("Ion");
            Assert.AreEqual(1, repo.TotiStudentii().Count());
            Assert.AreEqual("Maria", repo.TotiStudentii().First().Nume);
        }

        [TestMethod]
        public void TestStatistici()
        {
            var repo = new StudentRepository();
            repo.AdaugaStudent(new StudentCapstone("Ana", 8.0));
            repo.AdaugaStudent(new StudentCapstone("Alex", 4.0));
            repo.AdaugaStudent(new StudentCapstone("Maria", 10.0));

            Assert.AreEqual(2, repo.StudentiiPromovati().Count());
            Assert.AreEqual(7.33, Math.Round(repo.MediaGenerala(), 2));
        }
    }
}
