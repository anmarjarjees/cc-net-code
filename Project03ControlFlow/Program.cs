using System;
// the namespace "Project03ControlFlow" is the project folder name:
namespace Project03ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Conditions!");
            // write my code inside the Main() method block:
            // all your assignment answer goes here :-)
            /*
            Example1:
            Optimal temperature range: 18–27 C (64–80 F):​
            This is the recommended temperature range for "Data Centres"
            to operate efficiently and safely.
            */

            Console.WriteLine("Please Enter the current temperature in Fahrenheit:");
            // using ReadLine => To read the user input => line of Characters (Text => String)
            // save or retrieve the user input into a container "variable"
            // Specify the variable data type
            // we can use "double" data type for the temp value
            string temp = Console.ReadLine(); // this method will always returns string!

            /*
            * We can use "Convert" class to convert string to as number (either integer or double values)
            * OR:
            * using Parse()
            * 
            * The code below Convert.ToDouble() => returns a numeric value (double data type)
            */
            double temperature = Convert.ToDouble(temp); // "37" as a string => 37.0 as a number
            // Optimal temperature range: 18–27 in Celsius OR 64–80 Fahrenheit:​
            /*
             * Logic:
             * If the temperature is (18 or more) "AND" (less than or equal to 27)
             => 64.4°F to 80.6°F
             * 
             * Using "If Statement":
             * if (Our_Conditions) {
             * 
             * } else {
             * 
             * }
             * 
             * The temperature must be between this range (18-27) for optimal env.
             * Our_Condition: temperature >=18 AND temperature <=27
             * Optimal temperature range
             * 
             * In C# Logical Operators:
             * ************************
             * - AND => && => All conditions must be true
             * - OR => || => any condition must be true
             * - ! => NOT Operator
             */
            if (temperature >= 18 && temperature <= 27)
            {
                Console.WriteLine("Optimal temperature range");
            }
            else
            {
                Console.WriteLine("Not in the optimal temperature range!");
            }

            /*
             * What about an example of using "OR"?
             */
            // Example2: "Toronto Public Library" Access
            /*
             * Rule:
             * If you live OR work OR study in Toronto => library card is FREE :-)
             * Otherwise, you must pay a membership fee.
             * This example shows how to use logical OR (||) to combine 3 conditions.
             * 
             * Ask the user 3 questions:
             * Do you live in Toronto? (yes/no):
             * Do you work in Toronto? (yes/no):
             * Do you study in Toronto? (yes/no):
             * At least one of them must be "yes" ("true" in programming) to have a free library card
             ReadLine() => returns string!
             */
            Console.WriteLine("Do you live in Toronto? (yes/no):");
            /*
            * ?? ""
            * if the user press Enter key without typing any value,
            * C# will use the empty string "" instead :-)
            */
            string live = Console.ReadLine()?.ToLower().Trim()  ?? "";
            /* 
            Think in this way :-)
            ReadLine() => returns a string => In C# "string" has a method ToLower()
            ReadLine().ToLower()
             */

            Console.WriteLine("Do you work in Toronto? (yes/no):");
            string work = Console.ReadLine()?.ToLower().Trim() ?? "";

            Console.WriteLine("Do you study in Toronto? (yes/no):");
            string study = Console.ReadLine()?.ToLower().Trim()  ?? "";

            /*
             * Logic:
             * if the user: live OR work OR study in Toronto:
             * Then they can have a free card :-)
             * else they have to pay :-(
             * 
             * The comparison operator AND the assignment operator:
             * assignment operator using "=" => int x = 10
             * comparison operator "Equal to" using "==" => x == y
             * 
             * HOTKEY To format the code nicely :-)
                > CTRL K, CTRL D => (In Visual Studio IDE)
                > ALT + SHIFT + F => (In VS Code - local/GitHub)
             * 
             * work => Yes
             Things to consider:
             *******************
             * "Yes" == "yes" => FALSE
             * "YES" == "yes" => FALSE
             * "YeS" == "yes" => FALSE
             * "YEs" == "yes" => FALSE
             * "yes" == "yes" => TRUE
             * "  yes " == "yes" => FALSE
             * 
             * we need to always convert the user input into lowercase
             * to be on the safe side!
             "string" in C# has the following methods:
             - ToLower() => to convert all letters to lowercase
             - ToUpper() => to convert all letters to uppercase
            
            "string" in C# has the following method:
            - Trim() => trim the spaces before and after the user input
             */
            if (live == "yes" || work == "yes" || study == "yes")
            {
                Console.WriteLine("You are eligible for a FREE Toronto Public Library card!");
            }
            else
            {
                Console.WriteLine("You need to pay a membership fee.");
            }

            /*
            Comparison Operators:
            - ==  Equal to
            - !=  Not equal to
            - >   Greater than
            - <   Less than
            - >=  Greater than or equal to
            - <=  Less than or equal to

            Logical Operators:
            - &&  AND (both conditions must be true)
            - ||  OR (at least one condition must be true)
            - !   NOT (negates a condition)

            Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
           */

            /*
                * TASK => about Humidity in Data Centres:
                * ***************************************
                * Relative Humidity (RH) 40%–60% 
                * (This range balances moisture levels in the air):​
                * Below 40% RH => the air is too dry
                * Above 60% RH => the air is too moist​
                * 
                * - Ask the user to input the humidity value
                * - Check if it's in the range 40 to 60
            */
        } // Main()
    } // class
} // namespace
