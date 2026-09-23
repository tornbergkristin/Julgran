namespace Julgran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett tal: ");
            if (int.TryParse(Console.ReadLine(), out int antal))
            {
                for (int rad = 1; rad <= antal; rad++)
                {
                    Console.WriteLine("*");

                }
            }
            Console.WriteLine();
        }
    }
}
