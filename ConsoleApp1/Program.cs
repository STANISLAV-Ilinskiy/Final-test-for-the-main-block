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
            Console.WriteLine("\n");

            // Выводим исходный массив
            Console.WriteLine("Source array:");
            foreach (string item in originalArray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");

            // Создаем новый массив, содержащий строки длиной <= 3 символа
            string[] newArray = FilterShortStrings(originalArray);

            // Выводим новый массив
            PrintArray(newArray);
            Console.WriteLine("\n");
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

            // Уменьшаем размер массива до фактического количества элементов
            Array.Resize(ref resultArray, count);
            return resultArray;

        }

        // Функция для вывода массива на экран
        static void PrintArray(string[] array)
        {
            Console.WriteLine("New array:");
            foreach (string item in array)
            {
                Console.Write(item + ", ");
               
            }
        }
    }
}