using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _32_hw_22._03._2023_CarBuilder
{
    class Shop
    {
        Builder builder;
        public Shop(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.buildBody();
            builder.buildEngine();
            builder.buildWheels();
            builder.buildTransmission();
        }
    }
}
