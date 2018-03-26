using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAapp
{
    class Main
    {
        static void Main(string[] args)
        {
            DisplayInstructions();
            GPACalc aGPA = new GPACalc();

            string hours;

            Console.Write("**************************************************\n" +
                          "Enter hours or -1 to exit: ");
            hours = Console.ReadLine();

            while (hours != "-1")
            {
                aGPA.CreditHours = int.Parse(hours);
                Console.Write("Enter grade (A,B,C, or D): ");
                aGPA.Grade = Console.ReadLine();
                Console.Write("\n**************************************************\n" +
                          "Enter hours or -1 to exit: ");
                hours = Console.ReadLine();
            }

            Console.WriteLine("**************************************************\n" + aGPA.ToString());
            Console.Read();
        }

        static void DisplayInstructions()
        {
            Console.WriteLine("**************************************************\n" +
                              "***  You will be prompted to input number of hours   ***\n" +
                              "***  and the letter grade earned for the course.     ***\n" +
                              "***  GPA is calculated and displayed.                ***\n" +
                              "***  Enter as many grade/hour combination as needed. ***\n" +
                              "***                                                  ***\n" +
                              "***  -Enter -1 in the hours field to exit.           ***\n" +
                              "**************************************************");
        }
    }
}
