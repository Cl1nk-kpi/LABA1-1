using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        List<int> numbers = new List<int> { 5, 12, -15, 45, 105, 99, 8, -50, 0 };

        var targetNumbers = numbers.Where(x => x >= 10 && x <= 99);

        int count = targetNumbers.Count();


        double average = targetNumbers.DefaultIfEmpty(0).Average();

        if (count == 0)
        {
            Console.WriteLine(0);
            Console.WriteLine(0.0);
        }
        else
        {
            Console.WriteLine($"Кількість: {count}");
            Console.WriteLine($"Середнє арифметичне: {average}");
        }
    }
}
