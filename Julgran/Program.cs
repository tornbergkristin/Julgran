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

            //Console.Write("Ange granens höjd: ");
            //int höjd = int.Parse(Console.ReadLine());

            //int bredd = höjd * 2 - 1;
            //Random slump = new Random();
            //// Rita granens delar
            //for (int del = 1; del <= 3; del++)
            //{
            //    for (int rad = 0; rad < del + 1; rad++)
            //    {
            //        int stjärnor = rad * 2 + 1;
            //        int mellanslag = (bredd - stjärnor) / 2;

            //        for (int i = 0; i < mellanslag; i++)
            //            Console.Write(" ");

            //        for (int i = 0; i < stjärnor; i++)
            //        {
            //            // Första raden ska alltid vara en stjärna
            //            if (del == 1 && rad == 0)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                // Cirka 20% chans för en julkula
            //                if (slump.Next(5) == 1)
            //                {
            //                    Console.Write("o");
            //                }
            //                else
            //                {
            //                    Console.Write("*");
            //                }
            //            }
            //        }

            //        Console.WriteLine();
            //    }
            //}

            Random random = new Random();

            int antalGranar = 4;

            // Slumpa höjder en gång så granarna behåller sin form
            int[] höjder = new int[antalGranar];

            for (int i = 0; i < antalGranar; i++)
            {
                höjder[i] = random.Next(5, 10);
            }

            while (true)
            {
                Console.Clear();

                int maxHöjd = 0;

                foreach (int höjd in höjder)
                {
                    if (höjd > maxHöjd)
                        maxHöjd = höjd;
                }

                // Rita granarna rad för rad
                for (int rad = 0; rad < maxHöjd; rad++)
                {
                    for (int gran = 0; gran < antalGranar; gran++)
                    {
                        int höjd = höjder[gran];

                        if (rad < höjd)
                        {
                            int stjärnor = 2 * rad + 1;
                            int bredd = 2 * höjd - 1;
                            int mellanslag = (bredd - stjärnor) / 2;

                            for (int i = 0; i < mellanslag; i++)
                                Console.Write(" ");

                            for (int i = 0; i < stjärnor; i++)
                            {
                                // Toppen ska alltid vara en stjärna
                                bool ärToppen = (rad == 0);

                                if (!ärToppen && random.Next(6) == 0)
                                {
                                    // Slumpa färg på kulan
                                    Console.ForegroundColor =
                                    (ConsoleColor)random.Next(1, 16);

                                    Console.Write("o");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("*");
                                    Console.ResetColor();
                                }
                            }
                        }
                        else
                        {
                            // Tom yta under mindre granar
                            Console.Write(new string(' ', 2 * höjd - 1));
                        }

                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }

                //// Rita stammar
                //for (int gran = 0; gran < antalGranar; gran++)
                //{
                //    int höjd = höjder[gran];

                //    for (int i = 0; i < höjd - 1; i++)
                //        Console.Write(" ");

                //    Console.ForegroundColor = ConsoleColor.DarkYellow;
                //    Console.Write("|");
                //    Console.ResetColor();

                //    Console.Write(new string(' ', höjd + 3));
                //}

                Console.WriteLine();

                Thread.Sleep(500);
            }
        }


    }
    
}
