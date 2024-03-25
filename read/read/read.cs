using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

class read
{
    static void Main()
    {
        try
        {
            //Create a Stream reader object
            StreamReader sr = new StreamReader("C:/Users/CC/OneDrive/Desktop/writeNread.txt");

            //Create a list to store line from text document
            var lineList = new List<string>();

            //read the whole text document
            String line;

            while ((line = sr.ReadLine()) != null){
                lineList.Add(line);
            }

            sr.Close();

            //Convert text lines from list to array
            String[] textFile = lineList.ToArray();

            //Display all text stored on the array
            foreach (string text in textFile ) { 
                Console.WriteLine(text);
            }

        }
        catch(Exception e) { 
        
            Console.WriteLine("Exception error: \n" + e);
        
        }
        Console.ReadLine();
    }
}