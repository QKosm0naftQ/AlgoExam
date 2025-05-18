using AlgoExam.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bubble_sort b = new Bubble_sort();
            Quick_sort q = new Quick_sort();

            Console.Write("Podaj maksymalną długość tablicy (MAX): ");
            int maxLength;
            while (!int.TryParse(Console.ReadLine(), out maxLength) || maxLength < 3)
            {
                Console.Write("Błąd. Podaj liczbę całkowitą większą lub równą 3: ");
            }

            int[] originalArray = GenerateRandomArray(maxLength);

            Console.WriteLine("\nOryginalna tablica:");
            PrintArray(originalArray);

            List<(int Length, int BubbleOps, int QuickOps)> results = new List<(int, int, int)>();

            Console.WriteLine("\nBubble Sort:");
            for (int length = 3; length <= maxLength; length++)
            {
                int[] subArray = new int[length];
                Array.Copy(originalArray, subArray, length);

                int operationCount = b.BubbleSort(subArray);
                Console.WriteLine($"Długość: {length}, Operacje: {operationCount}");

                results.Add((length, operationCount, 0)); // Добавим только Bubble, Quick потом
                if (length == maxLength)
                {
                    PrintArray(subArray);
                }

            }

            Console.WriteLine("\nQuick Sort:");
            for (int length = 3; length <= maxLength; length++)
            {
                int[] subArray = new int[length];
                Array.Copy(originalArray, subArray, length);

                int operationCount = 0;
                q.QuickSort(subArray, 0, subArray.Length - 1, ref operationCount);
                Console.WriteLine($"Długość: {length}, Operacje: {operationCount}");

                // Обновим соответствующую запись в results
                int index = length - 3; // т.к. начинается с 3
                var old = results[index];
                results[index] = (old.Length, old.BubbleOps, operationCount);
                if (length == maxLength)
                {
                    PrintArray(subArray);
                }

            }
            Console.WriteLine("\nPorównanie ilości operacji:");
            Console.WriteLine("Długość | Bubble Sort | Quick Sort");
            Console.WriteLine("----------------------------------");

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Length,7} | {item.BubbleOps,12} | {item.QuickOps,11}");
            }

        }
        static int[] GenerateRandomArray(int length)
        {
            Random rand = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(1, 1001);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}