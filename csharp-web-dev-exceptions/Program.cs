using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by zero.");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName == "" || fileName == null)
            {
                throw new ArgumentNullException("No file!");
            }
            else
            {
                if (fileName.EndsWith(".cs"))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(12.0, 4.0));
                Console.WriteLine(Divide(10.0, 0.0));
            } catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> pair in students)
            {
                try
                {
                    Console.WriteLine(pair.Key + ": " + CheckFileExtension(pair.Value));
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine(pair.Key + ": " + "No file!");
                }

            }
        }
    }
}
