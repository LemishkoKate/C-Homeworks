using System;

namespace WarehouseApp
{
    public enum ItemCategory
    {
        Electronics,
        Furniture,
        Food
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] warehouse = new Item[10];
            int count = 0;

            while (true)
            {
                Console.WriteLine("\n=== STORE MENU ===");
                Console.WriteLine("1 - Add an item");
                Console.WriteLine("2 - Show all items");
                Console.WriteLine("3 - Update item quantity");
                Console.WriteLine("4 - Delete an item");
                Console.WriteLine("5 - Exit");
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter item name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Select category (0 - Electronics, 1 - Furniture, 2 - Food): ");
                    ItemCategory category = (ItemCategory)int.Parse(Console.ReadLine());

                    warehouse[count] = new Item(name, quantity, price, category);
                    count++;

                    Console.WriteLine("Item added!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nItem list:");
                    for (int i = 0; i < count; i++)
                    {
                        warehouse[i].ShowInfo();
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter item name to update: ");
                    string name = Console.ReadLine();

                    for (int i = 0; i < count; i++)
                    {
                        if (warehouse[i].Name == name)
                        {
                            Console.Write("Enter new quantity: ");
                            warehouse[i].Quantity = int.Parse(Console.ReadLine());
                            Console.WriteLine("Quantity updated!");
                        }
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Enter item name to delete: ");
                    string name = Console.ReadLine();

                    for (int i = 0; i < count; i++)
                    {
                        if (warehouse[i].Name == name)
                        {
                            for (int j = i; j < count - 1; j++)
                                warehouse[j] = warehouse[j + 1];

                            count--;
                            Console.WriteLine("Item deleted!");
                            break;
                        }
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
        }
    }
}
