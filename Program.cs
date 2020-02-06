using System;

namespace Berrios_Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number value out of a 100 to obtain letter grade for class.");

            // Setting an integer variable 
            int number = Convert.ToInt32(Console.ReadLine());
            string letter = "";

            // Start of conditional statements
            if (number >= 98 && number <= 100)
            {
                letter = "A+";
            }
            else if (number >= 92 && number <= 97)
            {
                letter = "A";
            }
            else if (number >= 90 && number <= 91)
            {
                letter = "A-";
            }
            else if (number >= 88 && number <= 89)
            {
                letter = "B+";
            }
            else if (number >= 82 && number <= 87)
            {
                letter = "B";
            }
            else if (number >= 80 && number <= 81)
            {
                letter = "B-";
            }
            else if (number >= 78 && number <= 79)
            {
                letter = "C+";
            }
            else if (number >= 72 && number <= 77)
            {
                letter = "C";
            }
            else if (number >= 70 && number <= 71)
            {
                letter = "C-";
            }
            else if (number >= 68 && number <= 69)
            {
                letter = "D+";
            }
            else if (number >= 62 && number <= 67)
            {
                letter = "D";
            }
            else if (number >= 60 && number <= 61)
            {
                letter = "D-";
            }
            else if (number >= 0 && number < 60)
            {
                letter = "F";
            }
            // Allows the user to correct input if outside of range 
            else
            {
                letter = "Invalid Input";
            }

            Console.WriteLine(letter);


          
        }
    }
}
