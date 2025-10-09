namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            string expr = Console.ReadLine();

            int result = 0;
            int number = 0;
            char sign = '+';

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (c >= '0' && c <= '9')
                {
                    number = number * 10 + (c - '0');
                }

                if (c == '+' || c == '-')
                {
                    if (sign == '+')
                        result += number;
                    else
                        result -= number;

                    sign = c;      
                    number = 0;  
                }

                if (i == expr.Length - 1)
                {
                    if (sign == '+')
                        result += number;
                    else
                        result -= number;
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
