using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Note-Taking Program!");
        Console.WriteLine("Type 'exit' to exit the program");
        Console.WriteLine("------------------------------------");

        string noteFilePath = "notes.txt";

        //Create the notes files if it doesn't exist
        if (!File.Exists(noteFilePath))
        {
            File.Create(noteFilePath).Close();
            Console.WriteLine("New note file created: notes.txt");
        }

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Enter your note: ");
            string note = Console.ReadLine();

            if (note.ToLower() == "exit")
            {
                isRunning = false;
                continue;
            }

            //Append the note to the file
            using (StreamWriter writer = File.AppendText(noteFilePath))
            {
                writer.WriteLine(note);
            }

            Console.WriteLine("Note saved succssfully!");
            Console.WriteLine("------------------------");
        }

        Console.WriteLine("Exiting the Note-Taking Program...");
    }
}
