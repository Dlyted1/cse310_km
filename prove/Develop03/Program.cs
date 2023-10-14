using System;

namespace ScriptureStudy
{

class Program
{
    static void Main()
    {
        //Console.WriteLine("Hello Develop03 World!");
        Scripture scripture = new Scripture ("Ephesians ", 5, 20,  "Giving thanks always for all things unto God and the Father in the name of our Lord Jesus Christ. ");
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nPress Enter to continue or type 'Quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "Quit")
                break;
            
            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("\nNice job! You memorized the scripture!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'Quit' to exit.");
        }
    }
}
}