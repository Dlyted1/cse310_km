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

          // Part 2: average of the entered numbers
          // By making one of the variables a float first, the computer knows that it has to
        // do the floating point division, and we get the decimal value that we expect.
          float average = (float)sum / numbers.Count;

            Console.WriteLine($"The sum is :  {sum}");
            Console.WriteLine($"The average is :  {average}");
        }
}
