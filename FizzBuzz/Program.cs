using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");
            while (true)
            {
                var fizzBuzz = new FizzBuzz();
                var number = GetNumber();
                Console.WriteLine(fizzBuzz.GetResult(number) + "\n");
                Console.WriteLine("Podaj kolejną liczbę:");

            }

        }

        private static int GetNumber()
        {
            int result;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Podano liczbę w nieprawidłowym formacie. Podaj prawidłową wartość:");
                    continue;
                }

            }

        }
    }
}
