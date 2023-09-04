using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_hw_22._03._2023_CarBuilder
{
    class DaewooLanos : Car
    {
        public override string ToString()
        {
            return $"Brand: Daewoo\nModel: Lanos\nBody: {body}\nEngine: {engine}\nWheels (R): {wheels}\nTransmisson: {transmission}";
        }
    }

    class DaewooLanosBuilder : Builder
    {
        DaewooLanos product = new DaewooLanos();
        public override void buildBody()
        {
            product.body = "Седан";
        }
        public override void buildEngine()
        {
            product.engine = 98;
        }
        public override void buildWheels()
        {
            product.wheels = 13;
        }
        public override void buildTransmission()
        {
            product.transmission = "5 Manual";
        }
        public override Car getResult()
        {
            return product;
        }
    }
}
