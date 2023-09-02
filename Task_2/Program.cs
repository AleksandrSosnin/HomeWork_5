/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/



class Program
{
    static void Main()
    {
        int arraySize = 5;
        int[] numbers = new int[arraySize];
        Random random = new Random();

            for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = random.Next(-99, 99); 
        }

        Console.WriteLine("Исходный массив:");
            foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
            Console.WriteLine();

        int sum = 0;
            for (int i = 1; i < arraySize; i += 2)
        {
            sum += numbers[i];
        }
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }
}



