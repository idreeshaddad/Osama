using System.ComponentModel;

namespace Osama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHello();
            PrintName("Idrees Haddad");

            double theBeta = GetBeta();
            double sumResult = GetSum(1.66, 257.11);
        }


        static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        static void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }

        static double GetBeta()
        {
            return 12365;
        }

        static double GetSum(double firstNumber, double secondNumber) { 
            return firstNumber + secondNumber;
        }
    }
}