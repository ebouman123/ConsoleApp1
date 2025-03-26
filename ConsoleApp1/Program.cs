using System.Threading;
using System;
using System.Collections.Generic;

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

            //* String Equals Function *//

            // string message = "Hello";
            // string compare = "Hello";

            // can use this with empty strings as well: if name.Equals("")
            // better to use this then == with arrays

            // if (message == compare) // use message.Equals(compare) instead
            // {
            //     Console.WriteLine("Same");
            // }
            // else
            // {
            //     Console.WriteLine("Different");
            // }

            // Console.ReadLine();

            //* String Iteration(looping) *//

            // string message = "Gordon is awesome"; // remember strings are basically arrays

            // // Console.WriteLine(message[0]);
            // // Console.WriteLine(message[1]);
            // // Console.WriteLine(message[2]);
            // // Console.WriteLine(message[3]);
            // // Console.WriteLine(message[4]);

            // for (int i = 0; i < message.Length; i++)
            // {
            //     Console.Write(message[i]);
            //     Thread.Sleep(100); // 1000ms = 1 sec
            // }

            // Console.WriteLine();
            // Console.WriteLine(message.Contains("G"));

            // bool contains = false;

            // for (int i = 0; i < message.Length; i++)
            // {
            //     if (message[i].Equals('G'))
            //     {
            //         contains = true;
            //     }
            // }

            // Console.WriteLine(contains);

            // Console.ReadLine();

            //* String IsNullOrEmpty Function *//

            // does what is says, empty string is still a string
            // also can't run functions on null values
            // returns true if it isn't null or empty

            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();

            // Console.WriteLine($"Your name is {name}");

            // // if (name != "")
            // //     Console.WriteLine("0");

            // // if (!name.Equals(""))
            // //     Console.WriteLine("1");

            // if (!string.IsNullOrEmpty(name))
            //     Console.WriteLine("2");


            //* Exercise: Print string in reverse *//
            // Print in order and reverse

            // Console.Write("Enter Your Message: ");
            // string message = Console.ReadLine();

            // for (int i = 0; i < message.Length; i++)
            //     {
            //         Console.Write(message[i]);
            //     }

            // Console.WriteLine();

            // for (int i = message.Length; i > 0; i--)
            //     {
            //         Console.Write(message[i - 1]);
            //     }

            // Console.ReadLine();

            //* Exercise: Password Checker *//

            // Ask user to enter password and store
            // Ask user to enter password again and store
            // Check if they both contain something
            // If same, print passwords match, if not, print passwords do not match
            // If empty print please enter a password

            // Console.Write("Choose a password: ");
            // string password = Console.ReadLine();

            // Console.Write("Re-enter your password: ");
            // string passwordConfirmation = Console.ReadLine();

            // if (password == passwordConfirmation && !string.IsNullOrEmpty(password))
            //     {
            //         Console.WriteLine("Passwords match");
            //     }
            // else if (password != passwordConfirmation)
            //     {
            //         Console.WriteLine("Passwords do not match");
            //     }
            // else 
            //     {
            //         Console.WriteLine("Please choose a password");
            //     }

            //* Arrays *//

            // int[] numbers = new int[3];
            // numbers[0] = 5;
            // numbers[1] = 10;
            // numbers[2] = 15;

            // const int angleCount = 3;
            // int[] angles = new int[angleCount];

            // for (int i = 0; i < angles.Length; i++)
            //     {
            //         Console.Write($"Enter angle {i + 1}: ");
            //         angles[i] = Convert.ToInt32(Console.ReadLine());
            //     }

            // int angleSum = 0;

            // foreach (int angle in angles)
            //     {
            //         angleSum += angle;
            //     }

            // Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");

            //* Array Sorting *//
            // string functions tend to return the new string, array functions tend to return void

            // int[] numbers = new int[] // another way to initialize array values
            //     {
            //         2, 1, 9, 4, 3, 6, 2
            //     };

            // Array.Sort(numbers);

            // foreach (int number in numbers)
            //     {
            //         Console.Write($"{number} ");
            //     }

            //* Array Reversal *//

            // int[] numbers = new int[]
            //     {
            //         1, 2, 3, 4, 5
            //     };

            // Array.Reverse(numbers); // better than having the database do this

            // foreach (var item in numbers)
            //     {
            //         Console.Write($"{item} ");
            //     }

            //* Array Clearing *//

            // int[] numbers = new int[]
            //     {
            //         1, 2, 3, 4, 5
            //     };

            // Array.Clear(numbers, 0, numbers.Length); // this would replace all ints with 0 (default value for ints) - can use key word default
            // // (Array, starting index, ending index)

            // Console.ReadLine();

            //* Array IndexOf *//

            // int[] numbers = new int[]
            //     {
            //         11, 423, 63, 91, 2
            //     };

            // Console.Write("Enter a number you'd like to search: ");
            // int search = Convert.ToInt32(Console.ReadLine());

            // int position = Array.IndexOf(numbers, search);
            // // returns the first match then stops (Array, search value, range(optional))
            // // if not found, returns -1

            // if (position > -1)
            //     {
            //         Console.Write($"Number found at index {position}");
            //     }
            // else
            //     {
            //         Console.Write("Number not found");
            //     }

            // Console.ReadLine();

            //* Lists *//

            // List<int> listNumbers = new List<int>();

            // for (int i = 0; i < 3; i++)
            // {
            //     Console.Write("Enter a number: ");
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     listNumbers.Add(num);
            // }

            // for (int i = 0; i < listNumbers.Count; i++) //.Count for lists to see length
            // {
            //     System.Console.WriteLine(listNumbers[i]);
            // }

            // listNumbers.RemoveAt(0);

            // foreach (var item in listNumbers)
            // {
            //     Console.WriteLine(item);
            // }

            //* Dictionary *//
            // like objects in JS

            // Dictionary<int, string> names = new Dictionary<int, string>
            //     {
            //         // key values like objects, keys must be unique <key, value>
            //         {1, "Gordon"},
            //         {2, "Sammi"}
            //     };

            // // names.Add(1, "Gordon");
            // // names.Add(2, "Sammi");


            // for (int i = 0; i < names.Count; i++)
            // {
            //     KeyValuePair<int, string> pair = names.ElementAt(i);
            //     Console.WriteLine($"{pair.Key} - {pair.Value}");
            // }

            // foreach (KeyValuePair<int, string> item in names)
            // {
            //     Console.WriteLine($"{item.Key} - {item.Value}");
            // }

            // Dictionary<string, string> teachers = new Dictionary<string, string>
            // {
            //     {"Math", "Gordon"},
            //     {"English", "Sammi"}
            // };

            // // Console.WriteLine(teachers["Math"]);

            // if (teachers.TryGetValue("Math", out string teacher)) // avoids errors if key doesn't exist
            // {
            //     Console.WriteLine(teacher);
            // }
            // else
            // {
            //     Console.WriteLine("Math teacher not found");
            // }

            // if (teachers.ContainsKey("Math"))
            // {
            //     teachers.Remove("Math");
            // }
            // else
            // {
            //     Console.WriteLine("Math not found");
            // }


            //* Exercise Odd/Even number split *//

            /* 
            Create 2 lists with int data type, one for even, one for odd
            - Loop from 0-20
                - If number is even, add to even list
                - If number is odd, add to odd list
            - Print even list
            - Print odd list
            */

            // List<int> odd = new List<int>();
            // List<int> even = new List<int>();

            // for (int i = 0; i <= 20; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         even.Add(i);
            //     }
            //     else
            //     {
            //         odd.Add(i);
            //     }
            // }

            // Console.WriteLine("Printing even numbers:");

            // foreach (var item in even)
            // {
            //     Console.Write($"{item} ");
            // }

            // Console.WriteLine(Environment.NewLine + "Printing odd numbers:");

            // foreach (var item in odd)
            // {
            //     Console.Write($"{item} ");
            // }

            // Console.ReadLine();

            //* Array of Multiples *//

            /*
                Define and initialize two ints (num, length)
                e.g. (7, 5) -> (7, 14, 21, 28, 35)
                Create int array with size length
                loop through and insert the value into the array
                print the final array
            */

            // int num = 7;
            // int length = 5;

            // int[] result = new int[length];

            // int counter = 0;

            // for (int i = 1; i < result.Length; i++, counter++)
            // {
            //     result[counter]= num * i;
            // }

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }

            //* Functions *//
            // must start with static void Main(string[], args){}
            // static means you can use it without creating a new instance of the function
            // public means everything has access to the function
            // non-static you would have to reference the class e.g. - Test test = new Test(); -> test.something();
            // with static you can just reference the class e.g. - Test.something();
            // void means function returns nothing

            WelcomeMessage();


        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome, Gordon!");
        }
    }
}