using System;

class Program
{
    static void Main(string[] args)
    {

Console.WriteLine("Hello Prep3 World!");

// Part 1 and 2 with loop
Console.Write("What is the magic number? ");
int magicNumber = int.Parse(Console.ReadLine());

int guess;

do
{

    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    if (magicNumber > guess)
    {
        Console.WriteLine("Higher");
    }
    else if (magicNumber < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("You guessed it!");
    }
   } while (guess != magicNumber);
  }
}