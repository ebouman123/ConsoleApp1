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

            int age = -10;

            Console.WriteLine(age >= 0 ? "Valid" : "Invalid");
        }
    }
}