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

                int operationCount = BubbleSort(subArray);
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
                QuickSort(subArray, 0, subArray.Length - 1, ref operationCount);
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

        static int BubbleSort(int[] array)
        {
            int operationCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    operationCount++;
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                        operationCount++;
                    }
                }
            }
            return operationCount;
        }


        // Массив [8, 4, 7, 3, 5]
        static void QuickSort(int[] array, int low, int high, ref int operationCount)
        //          QuickSort(array, 0, 4, ref operationCount)
        {
            if (low < high)
            {
               int pivotIndex = Partition(array, low, high, ref operationCount);
            //  return i + 1     (Partition)
                QuickSort(array, low, pivotIndex - 1, ref operationCount);
            //  QuickSort(array, 0, 1, ref count) левая часть
            //  Массив: [4, 3]
            //  pivot = 3
            //  i = -1
            //  | j | array\[j] | < pivot? | i  | Действие | array          |
            //  | - | --------- | -------- | -- | -------- | -------------- |
            //  | 0 | 4         | ❌       | -1 | —        | \[4, 3, 5,...] |
            //  Swap(i + 1 = 0, high = 1) → Swap(0, 1)
            //  Массив: [3, 4, 5, 8, 7]
                QuickSort(array, pivotIndex + 1, high, ref operationCount);
            //  QuickSort(array, 3, 4, ref count)  // правая часть
            //  Массив: [8, 7]
            //  pivot = 7
            //  i = 2
            //  | j | array\[j] | < pivot? | i | Действие | array            |
            //  | - | --------- | -------- | - | -------- | ---------------- |
            //  | 3 | 8         | ❌        | 2 | —        | \[3, 4, 5, 8, 7] |
            //  Swap(i+1 = 3, high = 4) → Swap(3, 4)
            // Итоговый массив: [3, 4, 5, 7, 8]
            }
        }

        static int Partition(int[] array, int low, int high, ref int operationCount)
        {
            int pivot = array[high];//pivot = 5
            int i = low - 1;//i = -1
            // | j | array[j] | array[j] < pivot? | i  | Действие  | array            |
            // | - | -------- | ------------------| -- | --------- | ---------------- |
            // | 0 | 8         | ❌ нет           | -1 | —         | \[8, 4, 7, 3, 5] |
            // | 1 | 4         | ✅ да            | 0  | Swap(0,1) | \[4, 8, 7, 3, 5] |
            // | 2 | 7         | ❌ нет           | 0  | —         | \[4, 8, 7, 3, 5] |
            // | 3 | 3         | ✅ да            | 1  | Swap(1,3) | \[4, 3, 7, 8, 5] |
            for (int j = low; j < high; j++)
            {
                operationCount++; // сравнение
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                    operationCount++; // обмен
                }
            }

            Swap(array, i + 1, high);
            operationCount++; // финальный обмен
            return i + 1;
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
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
