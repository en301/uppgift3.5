using System;
using System.Diagnostics.CodeAnalysis;

namespace uppgift_3_5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ut två tal med ett mellanslag imellan...");
            string tal = Console.ReadLine();

            int talindex = tal.IndexOf(" ");
            double tal1 = double.Parse(tal[.. talindex]);
            double tal2 = double.Parse(tal[talindex..]);

            Console.WriteLine("Välj ett räkne sätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    double sum = tal1 + tal2;
                    Console.WriteLine("Dina tal plus varandra blir "+ sum);
                    break;
                case "2":
                    double sum2 = tal1 - tal2;
                    Console.WriteLine("Dina tal minus varandra blir"+ sum2);
                    break;
                case "3":
                    double sum3 = tal1 * tal2;
                    Console.WriteLine("Dina tal gånger varandra blir"+ sum3);
                    break;
                case "4":
                    double sum4 = tal1 / tal2;
                    Console.WriteLine("Dina tal delat på varandra blir"+ sum4);
                    break;
                default:
                    Console.WriteLine("Varför valde du inget av de möjliga alternativen?");
                    break;
            }
            Console.ReadKey();

        }
    }
}