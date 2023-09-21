using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
        
            Console.Write("Enter a number: "); 
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);
            
           // Part 1: Compute the sum, or total, of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

          // Part 2: Compute the average of the numbers in the list
          // By making one of the variables a float first, the computer knows that it has to
          // do the floating point division, and we get the decimal value that we expect.
          float average = (float)sum / numbers.Count;

          // Part 3: Find the maximum, or largest, number in the list
          int maxNumber = numbers.Count > 0 ? numbers.Max() : 0;

            Console.WriteLine($"The sum is :  {sum}");
            Console.WriteLine($"The average is :  {average}");
            Console.WriteLine($"The largest number is:  {maxNumber}");
        }
}
