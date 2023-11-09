using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace Osama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first drawing pattern: ");
            string pat1 = Console.ReadLine();

            Console.Write("Enter second drawing pattern: ");
            string pat2 = Console.ReadLine();

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 1; j < i; j += 2)
                {
                    Console.Write(" ");
                }
                for (int x = 9; x >= i; x--)
                {
                    if(x % 2 == 1)
                    {
                        Console.Write(pat1);
                    }
                    else
                    {
                        Console.Write(pat2);
                    }
                }
                Console.WriteLine();
            }

            for (int i = 9; i > 1; i -= 2)
            {
                for (int j = 3; j < i; j += 2)
                {
                    Console.Write(" ");
                }
                for (int x = 11; x >= i; x--)
                {
                    if (x % 2 == 1)
                    {
                        Console.Write(pat1);
                    }
                    else
                    {
                        Console.Write(pat2);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}