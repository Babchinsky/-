using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_hw_22._03._2023_CarBuilder
{
    class HyundaiGetz : Car
    {
        public override string ToString()
        {
            return $"Brand: Hyundai\nModel: Getz\nBody: {body}\nEngine: {engine}\nWheels (R): {wheels}\nTransmisson: {transmission}";
        }
    }

    class HyundaiGetzBuilder : Builder
    {
        HyundaiGetz product = new HyundaiGetz();
        public override void buildBody()
        {
            product.body = "Хэтчбек";
        }
        public override void buildEngine()
        {
            product.engine = 66;
        }
        public override void buildWheels()
        {
            product.wheels = 13;
        }
        public override void buildTransmission()
        {
            product.transmission = "4 Auto";
        }
        public override Car getResult()
        {
            return product;
        }
    }
}
