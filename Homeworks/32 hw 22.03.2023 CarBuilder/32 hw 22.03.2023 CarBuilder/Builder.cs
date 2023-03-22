using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _32_hw_22._03._2023_CarBuilder
{
    abstract class Builder
    {
        public abstract void buildBody();
        public abstract void buildEngine();
        public abstract void buildWheels();
        public abstract void buildTransmission();
        public abstract Car getResult();
    }
}
