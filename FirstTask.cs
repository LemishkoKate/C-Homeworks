namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // writeline - prints text with a new line at the end
            Console.WriteLine("Choose what you want to do: ");
            Console.WriteLine("1 - Convert from Celsius to Fahrenheit");
            Console.WriteLine("2 - Convert from Fahrenheit to Celsius");
            Console.WriteLine("Your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            // readline - reads a line of text from the console
            // convert.toint32 - converts a string to an integer

            // write - prints text without a new line at the end
            Console.Write("Enter the temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            double result;

            if (choice == 1)
            {
                result = temperature * 9 / 5 + 32;
                Console.WriteLine($"{temperature}°C is {result}°F");
                // $ - string interpolation
                // it allows you to build in expressions in a string
            }
            else if (choice == 2)
            {
                result = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature}°F is {result}°C");
            }
            else
            {
                Console.WriteLine("Invalid choice");

            }

        }
    }
}
