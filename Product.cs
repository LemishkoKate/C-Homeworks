using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRepository
{
    internal class Product
    {
        public string Name { get; set; }
        private int quantity;
        public int Quantity
        {
            get => quantity; 
            set
            {
                if (value < 0)
                {
                    quantity = 0;
                }
                else
                {
                    quantity = value;
                }
            }
        }

        private double price;
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }

        public Product(string name, int quantity, double price) 
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public static Product operator +(Product p, int value)
        {
            p.Quantity += value;
            return p;
        }

        public static Product operator -(Product p, int value)
        {
            p.Quantity -= value;
            return p;
        }

        public static bool operator ==(Product a, Product b)
        {
            return a.Price == b.Price;
        }

        public static bool operator !=(Product a, Product b)
        {
            return a.Price != b.Price;
        }

        public static bool operator >(Product a, Product b)
        {
            return a.Quantity > b.Quantity;
        }

        public static bool operator <(Product a, Product b)
        {
            return a.Quantity < b.Quantity;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product p)
                return this.Price == p.Price;
            return false;
        }

        public override int GetHashCode() => Price.GetHashCode();
    }

}

