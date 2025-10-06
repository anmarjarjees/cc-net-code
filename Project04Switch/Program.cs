// We will ignore the top-level statement options:
// See https://aka.ms/new-console-template for more information
using System;
// ALT+SHIFT+F => Format your code!
// namespace => our project (folder) name =>  Project04Switch
namespace Project04Switch
{
    // By default => Program.cs
    // We can change it => SwitchDemo (optional)
    // It's recommended to change both the file name and the class name within your code:
    internal class Program
    {
        static void Main(string[] args)
        {
            // we can just start coding here:
            Console.WriteLine("Working Switch Statement");
            // Switch Statement:
            // Prompt the user to enter a number between 1 and 5
            Console.Write("Enter a number from 1 to 5: ");
            string input = Console.ReadLine() ?? ""; // 5 => "5"
                                                     // we are expecting the user to input 1 to 5?
                                                     // if the user inputs abc!
            /*
             * We can ask C# to try parsing the input to an integer number
             * we are asking C# to try converting the "5" as a string to 5 as an integer
             * 
             * int.TryParse(): returns a boolean value: true and false
             * - int.TryParse("5"): True (it's a numeric value)
             * - int.TryParse("abc"): False (it's a numeric value)
             */
            // bool (boolean) => True or False:
            // int try to parse the "input" "5" and output an int value and save it into a variable "userNumber":
            // can accept any integer "343" or "7" or etc....
            // Returns: true if s was converted successfully; otherwise, false.
            bool isValidInt = int.TryParse(input, out int userNumber);
            /*
             * if the boolean variable "isValidInt" is True => the input is numeric :-)
             * otherwise the input is not a numeric value :-(
             */
            if (isValidInt) // true
            {
                // output the number with a simple text message: "You entered the number: 5"
                // Three different ways:
                // Way1: same way as with Java, PHP, and JS
                Console.WriteLine("You entered the number: " + userNumber);
                // Way2:
                Console.WriteLine($"You entered the number: {userNumber}");
                // Way3:
                Console.WriteLine("You entered the number: {0} ", userNumber);
                // Way3 a better example :-)
                string college = "Georgian";
                int semester = 4;
                string course = "C# Programming";
                Console.WriteLine("Our college name is {0}. We are in semester {1}, and our current course is {2}.", college, semester, course);
            }
            else // false
            {
                Console.WriteLine("That wasn't a valid number :-(");
                // We need to terminate/stop/quit/exit our application
                // strop our Main method here
                // terminate the Main method 
                // return to our application
                return; // exit the Main method
            }

            // if statement (Review):
            if (userNumber == 1)
            {
                Console.WriteLine("You entered ONE!");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("You entered TWO.");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("You entered THREE.");
            }
            else if (userNumber == 4)
            {
                Console.WriteLine("You entered FOUR.");
            }
            else if (userNumber == 5)
            {
                Console.WriteLine("You entered FIVE.");
            }
            else
            {
                Console.WriteLine("You entered a number outside the 1-5 range.");
            }

            // Switch Statement Syntax :-)
            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("You entered ONE!");
                    // every case must have "break":
                    break; // to stop the switch statement
                case 2:
                    Console.WriteLine("You entered TWO!");
                    break;
                case 3:
                    Console.WriteLine("You entered THREE!");
                    break;
                case 4:
                    Console.WriteLine("You entered FOUR!");
                    break;
                case 5:
                    Console.WriteLine("You entered FIVE!");
                    break;
                default:
                    Console.WriteLine("You entered a number outside the 1-5 range.");
                    break;
            } // switch


            // Let's one more example about Switch statement:
            double avg = 50; // Hard coding the avg value!
            /*
           * if the avg is greater than or equal to 80 => Well Done
           or in more details:
           * - avg >= 80 => Well Done
           * - avg >= 70 => Good Job
           * - else less than 70 => "Never give up! You can try again" 
           */
            Console.WriteLine("IF-ELSE Example:\n");
            // NOTE: \n to add a new line as with most of the programming language :-)
            if (avg >= 80)
            {
                // type cw then tab...
                // NOTE: No need for "System" as it's already in use (using/imported)
                System.Console.WriteLine("Well Done!");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Good Job!");
            }
            else
            {
                Console.WriteLine("Never give up! You can try again to get 70+ or 80+ next time :-)");
            }

            Console.WriteLine("\nSWITCH Example:\n");
            // Switch: Let's add more options:
            /* 
            avg < 50 => too low
            avg > 80.0 => too high
            avg > 70 => good
            avg >=60 => not bad
            avg >=50 => just passing
             */
            switch (avg)
            {
                case < 50:
                    Console.WriteLine($"Your average {avg}; too low.");
                    break;
                case > 80.0:
                    Console.WriteLine($"Your average {avg}; too high.");
                    break;
                case > 70:
                    Console.WriteLine($"Your average {avg}; good.");
                    break;
                case >= 60:
                    Console.WriteLine($"Your average {avg}; Not bad.");
                    break;
                case >= 50:
                    Console.WriteLine($"Your average {avg}; Just Passing.");
                    break;
                default:
                    Console.WriteLine($"Invalid {avg} value!");
                    break;
            }
        } // Main
    } // class
} // namespace

