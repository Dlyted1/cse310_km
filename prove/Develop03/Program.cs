using System;

namespace ScriptureStudy
{

class Program
{
    static void Main()
    {
        Console.Clear();
        //Console.WriteLine("Hello Develop03 World!");

        Scripture[] scriptures = new Scripture[]
        {
            new Scripture("Ephesians ", 5, 20,  "Giving thanks always for all things unto God and the Father in the name of our Lord Jesus Christ. "),
            new Scripture("James ", 1, 5,  "If any of you lacks wisdom, let him ask of God, who gives to all liberally and without reproach, and it will be given to him. "),
            new Scripture("Isaiah ", 40, 31,  "But those who wait on the LORD Shall renew their strength; They shall mount up with wings like eagles, They shall run and not be weary, They shall walk and not faint. "),
            new Scripture("Proverbs ", 3, 5-6,  "Trust in the Lord with all thine heart; and lean not unto thine own understanding. “In all thy ways acknowledge him, and he shall direct thy paths.” This scripture comes with two admonitions, a warning, and a glorious promise. "),
            new Scripture("Isaiah ", 43, 2,  "When you pass through the waters, I will be with you; and when you pass through the rivers, they will not sweep over you. When you walk through the fire, you will not be burned; the flames will not set you ablaze.. "),

        };

        foreach (Scripture scripture in scriptures)
        {
        //Scripture scripture = new Scripture ("Ephesians ", 5, 20,  "Giving thanks always for all things unto God and the Father in the name of our Lord Jesus Christ. ");
        //Console.Clear();
        scripture.Display();
        Console.WriteLine("\nPress Enter to continue or type 'q' to quit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "q")  //changed "Q" to "q"
            {
                    return; // Exit program
            }
                
            
            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("\nNice job! You memorized the scripture!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'q' to quit.");
        }
    }
}
}
}