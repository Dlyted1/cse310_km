using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // public void DisplayResumeDetails()
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            // Calls the DisplayDetails method on each job
            // job.DisplayDetails();

            // Calls the Display method on each job
            job.Display();
        }

    }

}