using System.Security.AccessControl;

namespace Julgran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Ange antal rader: ");
            //int antal = int.Parse(Console.ReadLine());

            //for (int i = 0; i < antal; i++)
            //{
            //    // Mellanslag före stjärnorna
            //    for (int j = 0; j < antal - i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Stjärnor
            //    for (int j = 0; j < 2 * i + 1; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            Console.Write("Ange granens höjd: ");
            int höjd = int.Parse(Console.ReadLine());

            int bredd = höjd * 2 - 1;

            // Rita granens delar
            for (int del = 1; del <= 3; del++)
            {
                for (int rad = 0; rad < del + 1; rad++)
                {
                    int stjärnor = rad * 2 + 1;
                    int mellanslag = (bredd - stjärnor) / 2;

                    for (int i = 0; i < mellanslag; i++)
                        Console.Write(" ");

                    for (int i = 0; i < stjärnor; i++)
                        Console.Write("*");

                    Console.WriteLine();
                }
            }


        }
    }
}
