namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Gordon";
            Console.WriteLine($"Hi {name}");

            string textAge = "9";
            int age = Convert.ToInt32(textAge);
            System.Console.WriteLine($"{name} is {age} years old");
        }
    }
}