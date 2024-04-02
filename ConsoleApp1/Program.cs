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

            // Создаем новый массив, содержащий строки длиной <= 3 символа
            string[] newArray = FilterShortStrings(originalArray);

        }

        // Функция для фильтрации строк длиной <= 3 символа
        static string[] FilterShortStrings(string[] inputArray)
        {
            string[] resultArray = new string[inputArray.Length];
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    resultArray[count] = inputArray[i];
                    count++;
                }
            }

        }
}
