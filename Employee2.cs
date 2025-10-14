namespace WarehouseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0].Name = "John";
            employees[0].Age = 30;
            employees[0].Salary = 50000;

            employees[1].Name = "Mary";
            employees[1].Age = null;
            employees[1].Salary = 45000;

            employees[2].Name = "Alex";
            employees[2].Age = 25;
            employees[2].Salary = null;

            employees[3].Name = "Kate";
            employees[3].Age = null;
            employees[3].Salary = null;

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].ShowInfo();
            }
        }
    }
}
