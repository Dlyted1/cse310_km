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
            
           // Part 1: the sum of user entered numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
            Console.WriteLine($"The sum is :  {sum}");
        }
}
