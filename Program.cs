using System;

namespace PineTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string pine = "";
            bool run = true;
            while (run)
            {
                Console.WriteLine("enter your type of symbols");
                string yourPine = Console.ReadLine();
                Console.WriteLine("enter your free space symbols");
                string free = Console.ReadLine();
                Console.WriteLine("enter tree height");
                int pineLength = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < pineLength; i++)
                {
                    for (int j = pineLength; j > 0; j--)
                    {
                        pine = j <= i + 1 ? yourPine : free;
                        Console.Write(" ");
                        Console.Write(pine);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("нажмите 1 если хотите выйти из программы");
                string myswitch = Console.ReadLine();
                run = (myswitch != "1");
            }
            Console.ReadKey();
        }
    }
}
