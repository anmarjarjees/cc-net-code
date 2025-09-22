// See https://aka.ms/new-console-template for more information
Console.WriteLine("Learning about input and output in C#");
// PascalCase:
/*
 * Console => the "Console" object 
 * has a method => WriteLine => to output
 */
// Console.WriteLine("Hello, World!");
// Console.ReadLine();
// saving the project name to a container => variable:
/*
 * Every Variable has a data type!
 * C# => list of data types:
 * Alex => text => "string" data type
 * 12 => integer whole number => "int" data type
 * 17.5 => decimal number with fraction => "double" data type
 */
// we can create these variables:
// we use camelCase with variables names
string city = "Toronto";
// The variable 'city' is assigned but its value is never used
string program = "CSTN";
int year = 2025;
double courseAverage = 87.68;

Console.WriteLine("Enter your subject:");
// wait wait, could you please let enter my subject name?

// var anyNameYouLikeToUse = Console.ReadLine();
// avr for general variables
string subject = Console.ReadLine(); // Cloud Computing
// NOTE: We will ignore the warning about "Console.ReadLine()" for now
Console.WriteLine(subject); // Cloud Computing

// User-Friendly => Your current subject is ????
// Concatenation same as with Python and Java
Console.WriteLine("Your current subject is " + subject);
// Your current subject is Cloud Computing

Console.WriteLine("Enter your college name:");
string college = Console.ReadLine();

Console.WriteLine("So, your college name is: " + college);


Console.WriteLine("What's your age?"); // usually we input integer value like 38
                                       //   int age = Console.ReadLine();
                                       // Error C# Compiler: Cannot implicitly convert type 'string' to 'int'CS0029
/* 
Quick Reason:
 ReadLine() returns the next line of characters from the input stream,
 in other words, 
 ReadLine() => always returns a string!
 - Alex => "Alex"
 - 100 => "100"
 - 75.89 => "75.89"
 string in C# inclused with " and "
 */
string age = Console.ReadLine(); // the user enters 28 = ReadLine() => "28" => return "28"
Console.WriteLine("Your age is " + age);

Console.ReadLine();
Console.WriteLine("Thank you for your patience!");