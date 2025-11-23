namespace OperatorsOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureArray week = new TemperatureArray();
            week[0] = 10.5;
            week[1] = 12.3;
            week[2] = 9.0;

            Console.WriteLine("Середня температура: " + week.GetAverage());

            Product p1 = new Product("Apple", 10, 20.5);
            Product p2 = new Product("Orange", 5, 20.5);

            p1 = p1 + 5;  
            p2 = p2 - 2;  

            Console.WriteLine(p1.Quantity);
            Console.WriteLine(p2.Quantity);

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 > p2);        
        }
    }
}
