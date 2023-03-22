using System;
using System.ComponentModel;
using System.Linq;

namespace kt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Where meetodi kasutamisest paarisarvude filtreerimiseks
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Paarisarvud:");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }

            //TakeWhile meetodi kasutamisest elementide võtmiseks kuni tingimus on täidetud
            var numbersUntilGreaterThan5 = numbers.TakeWhile(n => n <= 5);
            Console.WriteLine("\nNumbrid, kuni 5 :");
            foreach (var number in numbersUntilGreaterThan5)
            {
                Console.Write(number + " ");
            }
        }
    }
}

