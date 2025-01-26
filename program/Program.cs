using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть перше число:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введiть друге число:");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"Сума двох чисел: {sum}");
    }
}
