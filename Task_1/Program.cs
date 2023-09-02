/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


class Program
{
    static void Main()
    {
        int[] arr = new int[10]; // Создаем массив

        FillArray(arr); // Заполняем массив случайными числами
        PrintArray(arr); // Выводим массив на экран

        int evenCount = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
    }

    static void FillArray(int[] ints)
    {
        Random rnd = new Random();
        for (int i = 0; i < ints.Length; i++)
            ints[i] = rnd.Next(100, 999);
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write($"{arr[i]} ");
        Console.WriteLine();
    }
}
