using System;

class program
{
    static void Main(string[] args)
    {


Console.WriteLine("Hello Prep3 World!");

// Part 1 and 2 
Console.Write("What is the magic number? ");
int number = int.Parse(Console.ReadLine());

Random random = new Random();
number = random.Next(1, 101);


int guess = 0;

while (guess != number)
{


    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());



    if (number > guess)
    {
        Console.WriteLine("Higher");
    }
    else if (number < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("You guessed it!");
    }
   }
 }
}
