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

            Console.Write("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (answer == actualAnswer)
            {
                System.Console.WriteLine("Nice job, you're correct!");
            }
            else
            {
                System.Console.WriteLine("How did you get that wrong?...");
            }
        }
    }
}