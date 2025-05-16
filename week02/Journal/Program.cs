using System;

class Program
{
    static void Main(string[] args)
    {
        journal thejournal = new journal();
        Entry anEntry = new Entry();
        anEntry.Display();
        
        Console.WriteLine("Hello World! This is the Journal Project.");
    }
}