namespace EvenNumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int a = int.Parse(Console.ReadLine());

            int originalNumber = a;
            int sum = 0;

            // length - length of a
            int digits = a.ToString().Length;

            while (a > 0)
            {
                int digit = a % 10;
                sum += (int)Math.Pow(digit, digits);
                a /= 10;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number");
            }
            else if (sum != originalNumber) 
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number");
            }

        }
    }
}
