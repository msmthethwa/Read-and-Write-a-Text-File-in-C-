using System;
using System.IO;

class write
{
    static void Main()
    {
        try {

            using (StreamWriter sw = new StreamWriter ("C:/Users/CC/OneDrive/Desktop/writeNread.txt"))
            {
                sw.WriteLine("You are tasked with creating a C# project to handle text file operations.");
            }

            Console.WriteLine("Successful updated text document");

        }
        catch (Exception e)
        {
            Console.WriteLine("Exception error: " + e);
        }
        Console.Read();
    }

}