using System;

namespace WarehouseApp
{
    public class Item
    {
        public string Name;
        public int Quantity;
        public double Price;
        public ItemCategory Category;

        public Item(string name, int quantity, double price, ItemCategory category)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Category = category;
        }

        public void ShowInfo()
        {
                Console.WriteLine($"Name: {Name}, Quantity: {Quantity}, Price: {Price}, Category: {Category}");
        }
    }

}
