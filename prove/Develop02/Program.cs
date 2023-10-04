using System;


class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        //JournalPrompts prompts = new JournalPrompts();

        List<string> prompts = new List<string>
         {
      "Who was the most interesting person I interacted with today? ",
      "What was the best part of my day? ", 
      "How did I see the hand of the Lord in my life today? ",
      "What was the strongest emotion I felt today? ",
      "If I had one thing I could do over today, what would it be? ",
      "Did you encounter a simple pleasure today? What was it? ",
      "What was the best part of my day? ",
      "What challenges did I face today? How did I overcome them? What can I learn from these experiences? ",
      "What did I learn today? How can I apply this knowledge in the future? ",
      "What was the weather like today? ",
      "What was a moment of joy, delight, or contentment today? ",
      "How can I make tomorrow even better? ",
      "How did I show gratitude today? ",
      "How did I feel at different moments throughout the day? ",
      "Who did I interact with today and what were those interactions like? ",
      "What were some unexpected events that took place today? ",
      "What did I do to make someone elses day better? ",
      "What is a favorite childhood memory that still brings me joy? ",
      "What is something silly that always makes me laugh? ",
      "If I could live in any time period or place, where would I choose and why? ",
      "What is a simple delight I have been enjoying lately? ",
      "What is happening in this present moment? ",
      "What are three things I can hear right now, and how do they sound? ",
      "What are three things I can smell right now, and how do they smell? ",
      "What are three things I am looking forward to in the next hour? ",
};

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\n~~~~ Welcome to your Journal! ~~~~");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nPlease choose an option: 1-5 ");
            string choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":  
                string prompt = GetRandomPrompt(prompts);
                journal.AddEntry(prompt);
                break;
            case "2":
                journal.DisplayEnteries();
                break;
            case "3":
                journal.SaveToFile();
                break;
            case "4":
                journal.LoadFromFile();
                break;
            case "5":
                quit = true;
                break;
            default:
                Console.WriteLine("Not an option, please choose again");
                break;
        }
    }
    Console.WriteLine("See you next time!");
    }

    static string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];


        }
        
    }

     

