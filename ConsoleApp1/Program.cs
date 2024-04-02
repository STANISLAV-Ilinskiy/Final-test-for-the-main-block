using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Введите исходный массив строк
            Console.WriteLine("Enter lines separated by commas:");
            string input = Console.ReadLine();
            string[] originalArray = input.Split(',');

            // Выводим исходный массив
            Console.WriteLine("Source array:");
            foreach (string item in originalArray)
            {
                Console.Write(item, ", ");
            }
            Console.WriteLine();

        }
    }
}
