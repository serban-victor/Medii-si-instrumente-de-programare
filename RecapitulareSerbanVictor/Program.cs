using System.Text.RegularExpressions;
using RecapitulareSerbanVictor.Capstone;
namespace RecapitulareSerbanVictor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ex9();

            //ex11();

            //ex12();

            //ex13();

            //ex14();

            //ex15();

            //ex16();

            //ex18();

            //ex19();

            //ex20();

            //ex21();

            //ex22();

            //Ex. 23
            //var result = ex23(1,2,3);
            //Console.WriteLine(result);

            //Ex. 24
            //string input = Console.ReadLine();
            //var reversedInput = ex24(input);
            //Console.WriteLine(reversedInput);

            //ex25();

            //ex26();

            //ex27();

            //ex28();

            //ex29();

            //ex31();

            //ex32();

            //ex33();

            //ex35();

            //ex36();

            ex37();


            // Ex. 9
            static void ex9()
            {
                int intVar = 5;
                double doubleVar = 2.0;
                string stringVar = "Hello there";
                bool boolVar = false;
                DateTime datetimeVar = DateTime.Now;
                //DateTime data2 = new DateTime(2026, 1, 14, 15, 30, 45);
            }

            //Ex. 11
            static void ex11()
            {
                const double pi = 3.14;
                const float tva = 0.21f;
            }

            //Ex. 12
            static void ex12()
            {
                double firstNum = Convert.ToDouble(Console.ReadLine());
                double secondNum = Convert.ToDouble(Console.ReadLine());
                double thirdNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Media celor 3 numere este: " + ((firstNum + secondNum + thirdNum) / 3));
            }


            //Ex. 13
            static void ex13()
            {
                Console.WriteLine("Introduc varsta: ");
                int varsta = int.Parse(Console.ReadLine());
                Console.WriteLine("Introdu email-ul: ");
                string email = Console.ReadLine();
                bool emailValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                if (varsta >= 18 && emailValid)
                {
                    Console.WriteLine("Datele sunt valide.");
                }
                else
                {
                    Console.WriteLine("Date invalide.");
                }
            }



            //Ex. 14
            static void ex14()
            {
                double number = double.Parse(Console.ReadLine());
                switch (number)
                {
                    case 0:
                        Console.WriteLine("The number is equal with 0");
                        break;
                    case < 0:
                        Console.WriteLine("The number is negative");
                        break;
                    case > 0:
                        Console.WriteLine("The number is positive");
                        break;
                }
            }


            // Ex. 15
            static void ex15()
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                }

                //int i = 2;
                //while (i <= 100)
                //{
                //    Console.Write(i + " ");
                //    i += 2;
                //}


                //int[] numbers = new int[100];
                //for (int k = 0; k < 100; k++)
                //{
                //    numbers[k] = k + 1;
                //}
                //foreach(int num in numbers)
                //{
                //    if (num % 2 == 0)
                //        Console.Write(num + " ");
                //}



            }





            //Ex. 16
            static void ex16()
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Console.Write("Factorial de {0} este 1", num);
                }
                else
                {
                    int factorial;
                    factorial = num;
                    for (int i = num - 1; i > 0; i--)
                    {
                        factorial = factorial * i;
                    }
                    Console.Write("Factorial de {0} este {1}", num, factorial);
                }
            }



            //Ex. 18
            static void ex18()
            {
                int number1 = 100;
                int number2 = 0;
                try
                {
                    Console.WriteLine(number1 / number2);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division of {0} by zero.", number1);
                }
                finally
                {
                    Console.WriteLine("Incearca din nou");
                }
            }

            //Ex. 19
            static void ex19()
            {
                try
                {
                    int age = -2;

                    if (age < 0)
                    {
                        throw new MyException("Varsta nu poate fi negativa");
                    }

                    Console.WriteLine("Varsta este valida.");
                }
                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //Ex. 20
            static void ex20()
            {
                int a = 5;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }


            //Ex. 21
            static void ex21()
            {
                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine("Suma numerelor este: " + sum);
            }


            //Ex. 22
            static void ex22()
            {
                var studenti = new List<StudentEx22>
            {
                new StudentEx22 { Nume = "Ion", Medie = 7.5 },
                new StudentEx22 { Nume = "Maria", Medie = 9.2 },
                new StudentEx22 { Nume = "Alex", Medie = 4.8 },
                new StudentEx22 { Nume = "Andrei", Medie = 6.0 }
            };
            
                Console.WriteLine("Studentii promovati:");
                foreach (var s in studenti)
                {
                    if (s.Medie >= 5)
                    {
                        Console.WriteLine($"{s.Nume} - {s.Medie}");
                    }
                }
            }


            //Ex.23
            static Tuple<int,int,int>ex23(int a, int b, int c)
            {
                // returnează valorile pentru exemplu
                return new Tuple<int, int, int>(a, b, c);
            }


            //Ex. 24
            static string ex24(string text)
            {
                char[] chars = text.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }


            //Ex. 25
            static void ex25()
            {
                Console.WriteLine("Introdu email-ul: ");
                string email = Console.ReadLine();
                bool emailValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (emailValid)
                {
                    Console.WriteLine("Email valid.");
                }
                else
                {
                    Console.WriteLine("Email invalid.");
                }
            }


            //Ex. 26
            static void ex26()
            {
                Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));
            }


            //Ex. 27
            static void ex27()
            {
                DateTime d1 = new DateTime(2026, 1, 15);
                DateTime d2 = new DateTime(2026, 1, 10);

                TimeSpan diff = d1 - d2;
                Console.WriteLine($"Diferenta dintre date este {diff.Days} zile");
            }


            //Ex. 28
            static void ex28()
            {
                Dictionary<int, string> catalog = new Dictionary<int, string>
                {
                    { 1, "Laptop" },
                    { 2, "Mouse" },
                    { 3, "Tastatura" },
                    { 4, "Monitor" }
                };
                Console.WriteLine("Catalog de produse:");
                foreach (var item in catalog)
                {
                    Console.WriteLine($"ID: {item.Key}, Produs: {item.Value}");
                }
            }


            //Ex. 29
            static void ex29()
            {
                List<int> numbers = new List<int> { 85, 22, 19, 15, 72, 3, 56 };

                var filtered = numbers.Where(n => n > 20);
                Console.WriteLine("Numere mai mari de 4: " + string.Join(", ", filtered));

                var sorted = numbers.OrderBy(n => n);
                Console.WriteLine("Numere sortate: " + string.Join(", ", sorted));

                int count = numbers.Count();
                int sum = numbers.Sum();
                double average = numbers.Average();
                Console.WriteLine($"Count: {count}, Sum: {sum}, Average: {average}");
            }


            //Ex. 31
            static void ex31()
            {
                StudentEx30 s1 = new StudentEx30 { Nume = "Ion", Medie = 7.5 };
                StudentEx30 s2 = new StudentEx30 { Nume = "Maria", Medie = 9.0 };

                s1.Afiseaza();
                s2.Afiseaza();
            }


            //Ex. 32
            static void ex32()
            {
                //fara parametri
                StudentEx32 s1 = new StudentEx32();
                s1.Afiseaza();

                //cu parametri
                StudentEx32 s2 = new StudentEx32("Maria", 9.0);
                s2.Afiseaza();
            }

            //Ex. 33
            static void ex33()
            {
                StudentEx33 s1 = new StudentEx33("", 12);
                s1.Afiseaza();
                StudentEx33 s2 = new StudentEx33("Ana", 9);
                s2.Afiseaza();
            }


            //Ex. 35
            static void ex35()
            {
                Animal a1 = new Animal("Animalul generic");
                Caine c1 = new Caine("Rex");
                Pisica p1 = new Pisica("Luna");

                a1.Vorbeste();
                c1.Vorbeste();
                p1.Vorbeste();

                List<Animal> animale = new List<Animal> { a1, c1, p1 };
                Console.WriteLine("\nFolosind polimorfism cu lista de animale:");
                foreach (var animal in animale)
                {
                    animal.Vorbeste();
                }
            }


            //Ex. 36
            static void ex36()
            {
                StudentPrintable s1 = new StudentPrintable("Ana", 9.5);
                StudentPrintable s2 = new StudentPrintable("Ion", 7.2);

                List<IPrintable> list = new List<IPrintable> { s1, s2 };

                foreach (var item in list)
                {
                    item.Print();
                }
            }


            //Ex. 37
            static void ex37()
            {
                ContBancarEx37 c1 = new ContBancarEx37(1000);
                ContBancarEx37 c2 = new ContBancarEx37(500);

                c1.Depune(200);
                c1.Retrage(50);
                c1.AfiseazaSold(); //1150

                c2.Retrage(600); //fonduri isnuficiente
                c2.AfiseazaSold(); //500

                Console.WriteLine($"Numar total conturi: {ContBancarEx37.NumarConturi}");
            }




        }
        class MyException : Exception
        {
            public MyException(string message) : base(message)
            {
            }
        }

        class StudentEx22
        {
            public string Nume { get; set; }
            public double Medie { get; set; }
        }

    }
}
