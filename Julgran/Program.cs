using System.Security.AccessControl;

namespace Julgran
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                Console.WriteLine();

                Thread.Sleep(500);
            }
        }


    }
    
}
