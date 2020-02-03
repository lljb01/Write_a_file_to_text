using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_a_file_to_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string line = Console.ReadLine();

            // Set a variable to the My Documents path.
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Write the string array to a new file named "writeLine.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "Data_Export.txt")))
            {
                //foreach (string line in lines)
                outputFile.WriteLine(line);
            }
        }
    }
}