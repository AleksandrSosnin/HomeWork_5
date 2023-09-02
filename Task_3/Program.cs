/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

class Program
{
    static void Main()
    {
        Random random = new Random();
        int arraySize = 10; 
        decimal[] numbers = new decimal[arraySize];
             
             for (int i = 0; i < arraySize; i++)
        {
            decimal randomNumber = Math.Round((decimal)(random.NextDouble() * 100), 2);
            numbers[i] = randomNumber;
        }

        decimal min = numbers[0];
        decimal max = numbers[0];

             foreach (decimal number in numbers)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }
        decimal difference = max - min;

        Console.WriteLine("Случайно сгенерированный массив десятичных чисел:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }
}
