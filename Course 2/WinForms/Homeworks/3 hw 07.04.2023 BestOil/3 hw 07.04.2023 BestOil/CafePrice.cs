using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_hw_07._04._2023_BestOil
{
    public class CafePrice
    {
        public decimal PriceHotDog { get; set; }
        public decimal PriceBurger { get; set; }
        public decimal PriceFry { get; set; }
        public decimal PriceCola { get; set; }

        public CafePrice(decimal PriceHotDog, decimal PriceBurger, decimal PriceFry, decimal PriceCola)
        {
            this.PriceHotDog = PriceHotDog;
            this.PriceBurger = PriceBurger;
            this.PriceFry = PriceFry;
            this.PriceCola = PriceCola;
        }
    }
}
