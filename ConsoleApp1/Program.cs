namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // string name = "Gordon";
            // Console.WriteLine($"Hi {name}");

            // string textAge = "9";
            // int age = Convert.ToInt32(textAge);
            // System.Console.WriteLine($"{name} is {age} years old");

            //* odd/even exercise *//

            // int first = 21;
            // int second = 12;

            // int remainder = first % second;

            // first = 923;

            // int newRemainder = first % second;

            // System.Console.WriteLine($"New Remainder = {newRemainder}");

            //* user input exercise *//

            // System.Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // System.Console.Write("Enter your age: ");
            // // string ageInput = Console.ReadLine();
            // int age = Convert.ToInt32(Console.ReadLine());

            // System.Console.WriteLine($"Okay, so your name is {name} and you are {age} years old? That is so cool {name}!");

            // if (age >= 14)
            // {
            //     System.Console.WriteLine("Wow, you're a senior cat");
            // }
            // else
            // {
            //     System.Console.WriteLine("You're still a baby!");
            // }

            //* Calculations test exercise *//

            // Console.Write("Enter the first number: ");
            // string numberAInput = Console.ReadLine();
            // int numberA = Convert.ToInt32(numberAInput);

            // Console.Write("Enter the second number: ");
            // string numberBInput = Console.ReadLine();
            // int numberB = Convert.ToInt32(numberBInput);

            // int answer = numberA * numberB;

            // Console.Write("Value of " + numberA + " x " + numberB + ": ");
            // string answerInput = Console.ReadLine();
            // int actualAnswer = Convert.ToInt32(answerInput);

            // if (answer == actualAnswer)
            // {
            //     System.Console.WriteLine("Nice job, you're correct!");
            // }
            // else
            // {
            //     System.Console.WriteLine("How did you get that wrong?...");
            // }

            //* Switch Statements *//

            // Console.Write("Enter a day of the week: ");
            // int day = Convert.ToInt32(Console.ReadLine());

            // switch (day)
            // {
            //     case 1:
            //         Console.WriteLine("Monday");
            //         break;
            //     case 2:
            //         Console.WriteLine("Tuesday");
            //         break;
            //     case 3:
            //         Console.WriteLine("Wednesday");
            //         break;
            //     case 4:
            //         Console.WriteLine("Thursday");
            //         break;
            //     case 5:
            //         Console.WriteLine("Friday");
            //         break;
            //     case 6:
            //         Console.WriteLine("Saturday");
            //         break;
            //     case 7:
            //         Console.WriteLine("Sunday");
            //         break;
            //     default:
            //         Console.WriteLine("Please enter a number between 1 and 7");
            //         break;
            // }


            //* For Loops *//

            // Console.Write("How many times do you want to meow?");
            // int loopCounter = Convert.ToInt32(Console.ReadLine());

            // if (loopCounter <= 0)
            // {
            //     Console.WriteLine("Why don't you want to meow?");
            // }
            // else
            // {
            //     for (int i = 0; i < loopCounter; i++)
            //     {
            //         Console.WriteLine("MEOW");
            //     }
            // }

            //* Conditional operator *//

            // int age = -10;

            // Console.WriteLine(age >= 0 ? "Valid" : "Invalid");

            //* Numeric formatting *//

            // double value = 1000D / 12.34D; // must specify double, otherwise it will be calculated as an int

            // Console.WriteLine(value);
            // Console.WriteLine(string.Format("{0:0}", value));
            // Console.WriteLine(string.Format("{0:0.0}", value));
            // Console.WriteLine(string.Format("{0:0.#}", value)); // # will take off any trailing zeroes
            // Console.WriteLine(string.Format("{0:0.00}", value));

            // double money = 10D / 3D;

            // Console.WriteLine(money);
            // Console.WriteLine(string.Format("$10 / $3 = ${0:0.00}", money));

            //* TryParse Function *//

            // Console.Write("Enter a number: ");
            // string numInput = Console.ReadLine();
            // // int num = Convert.ToInt32(numInput); // invalid input will cause the program to crash
            // int num = 0;

            // bool success = int.TryParse(numInput, out num); // will attempt to parse the numInput and will output the number if successful

            // if (success)
            // {
            //     Console.WriteLine(num);
            // }
            // else
            // {
            //     Console.WriteLine("Failed to convert");
            // }

            // Console.ReadLine();

            //* Times Table Exercise *//
            // ask the user for a number for the table
            // Write a for loop to print X times table

            // Console.Write("Enter a number: ");
            // int number = Convert.ToInt32(Console.ReadLine());

            // for (int i = 1; i <= 10; i++){
            //     Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            // }

            //* FizzBuzz *//
            // Create a for loop from 1 to X (15)
            // 3 and 5 = FizzBuzz
            // 3 = Fizz
            // 5 = Buzz
            // else = number

            // for (int i = 1; i <= 15; i++)
            // {
            //     if (i % 3 == 0 && i % 5 == 0)
            //     {
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if (i % 5 == 0)
            //     {
            //         Console.WriteLine("Buzz");
            //     }
            //     else if (i % 3 == 0)
            //     {
            //         Console.WriteLine("Fizz");
            //     }
            //     else
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            //* String Literal *//
            // \ acts as an escape character
            // \t (tab), \n (new line)
            // @ is a verbatim identifier
            // can't combine verbatim with \t, \n, etc. - would need to concatenate with +

            // string path = "C:\\Users\\ebouman\\Desktop\\C# Course";
            // string path2 = @"C:\Users\ebouman\Desktop\C# Course";
            // string speech = "He said \"something\"";
            // string speech2 = @"He said ""something"""; // use double quotes with @
            // Console.WriteLine(path);
            // Console.WriteLine(path2);
            // Console.WriteLine(speech);
            // Console.WriteLine(speech2);
            // Console.ReadLine();


            //* String formatting *//
            // {} can be used to assign variables, going up from 0

            // string name = "Gordon";
            // int age = 8;

            // Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
            // Console.WriteLine("Name: {0}\nAge: {1}", name, age);

            //* String Interpolation *//
            // Same as JavaScript

            // string name = "Gordon";
            // int age = 8;

            // Console.WriteLine($"Hi, my name is {name} and I'm {age} years old");

            //* String Concatenation *//
            // Same as JS, use +
            // string name = "Gordon";
            // int age = 8;

            // string test = string.Concat("Your name is ", name, " and your age is ", age);

            // string[] names = new string[] {"Gordon", "Sammi", "Daisy"};
            // Console.WriteLine(string.Concat(names));

            //* Empty String *//

            // string name = string.Empty;
            // Can use this instead of empty quotes, like in if statements

            
        }
    }
}