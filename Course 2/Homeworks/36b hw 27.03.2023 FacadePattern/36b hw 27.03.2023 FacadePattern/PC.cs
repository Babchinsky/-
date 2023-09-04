using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36b_hw_27._03._2023_FacadePattern
{
    public class PC
    {
        GPU gpu;
        RAM ram;
        HDD hdd;
        OpticalDrive opticalDrive;
        PowerUnit powerUnit;
        Sensors sensors;


        public PC(GPU gpu, RAM ram, HDD hdd, OpticalDrive opticalDrive, PowerUnit powerUnit, Sensors sensors)
        {
            this.gpu = gpu;
            this.ram = ram;
            this.hdd = hdd;
            this.opticalDrive = opticalDrive;
            this.powerUnit = powerUnit;
            this.sensors = sensors;
        }
        public void On()
        {
            powerUnit.On();
            sensors.On();
            powerUnit.PowerUpGPU();
            gpu.On();
        }
        public void Off()
        {
            gpu.Off();
            sensors.Off();
            powerUnit.Off();
        }
    }
}
