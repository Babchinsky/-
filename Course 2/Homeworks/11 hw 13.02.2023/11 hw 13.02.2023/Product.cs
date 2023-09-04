using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_hw_13._02._2023
{
    internal class Product
    {
        private Money Price { get; set; }
        private int Count { get; set; }

        public Product():this(new Money(100,50),1) { }
        public Product(Money Price, int Count) 
        {
            this.Price = Price;
            this.Count = Count;
        }
        public Product(Product obj) :this(obj.Price, obj.Count)
        { }

        public static Product operator +(Product obj,Money add)
        {
            Product result = new Product(obj);
            result.Price.Whole += add.Whole;
            result.Price.Pennies += add.Pennies;
            return result;
        }

        public static Product operator -(Product obj, Money add)
        {
            Product result = new Product(obj);
            result.Price.Whole -= add.Whole;
            result.Price.Pennies -= add.Pennies;
            return result;
        }

        public static Product operator -(Product obj, int count)
        {
            Product result = new Product(obj);
            result.Count -= count;
            return result;
        }
        public static Product operator +(Product obj, int count)
        {
            Product result = new Product(obj);
            result.Count += count;
            return result;
        }


        public override string ToString()
        {
            return $"Prict: {Price.Sum()}\nCount: {Count}\nTotal: {Price.Sum() * Count}";
        }

    }
}
