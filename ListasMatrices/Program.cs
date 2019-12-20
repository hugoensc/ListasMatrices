using System;
using System.Collections.Generic;

namespace ListasMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Hugo", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var nombres = new List<string> { "Hugo", "Ana", "Felipe" };

            foreach (var nombre in nombres)
            {
                Console.WriteLine($"Hello {nombre.ToUpper()}! t (°_°)t");
            }

            nombres.Add("Maria");
            nombres.Add("Bill");
            nombres.Remove("Ana");

            foreach (var nombre in nombres)
            {
                Console.WriteLine($"Hello {nombre.ToUpper()}!");
            }

            Console.WriteLine($"My name is {nombres[0]}.");
            Console.WriteLine($"I've added {nombres[2]} and {nombres[3]} to the list.");

            Console.WriteLine($"The list has {nombres.Count} people in it");
            Console.WriteLine($"The list has {names.Length} people in it");

            var index = nombres.IndexOf("Felipe");

            if (index != -1)
            {
                Console.WriteLine($"The name {nombres[index]} is at index {index}");
            }

            var notFound = nombres.IndexOf("Not Found");
            Console.WriteLine($"When a item is not found, IndexOf returns {notFound}");

            nombres.Sort();
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"Hello {nombre.ToUpper()}!");
            }


            //Lista de numeros

            var fibonacciNumbers = new List<int> { 1, 1 };

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

            var fibonacciExample = new List<int> { 1, 1 };

            for (int counter = 0; counter < 18; counter++)
            {
                var before = fibonacciExample[fibonacciExample.Count - 1];
                var before2 = fibonacciExample[fibonacciExample.Count - 2];
                fibonacciExample.Add(before + before2);
            }

            foreach (var item in fibonacciExample)
            {
                Console.WriteLine(item);
            }


            //Oh tambien puede quedar de la siguiente manera

            var fibonacciExample2 = new List<int> { 1, 1 };

            while (fibonacciExample2.Count < 20)
            {
                var bfore = fibonacciExample2[fibonacciExample2.Count - 1];
                var bfore2 = fibonacciExample2[fibonacciExample2.Count - 2];

                fibonacciExample2.Add(bfore + bfore2);
            }

            foreach (var item in fibonacciExample2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
