using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_hw_08._03._2023_LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device[] devices1 = new Device[]
            {
                new Device { Name = "Device1", Manufacturer = "Manufacturer1", Cost = 100 },
                new Device { Name = "Device2", Manufacturer = "Manufacturer1", Cost = 200 },
                new Device { Name = "Device3", Manufacturer = "Manufacturer2", Cost = 300 }
            };

            Device[] devices2 = new Device[]
            {
                new Device { Name = "Device4", Manufacturer = "Manufacturer2", Cost = 400 },
                new Device { Name = "Device5", Manufacturer = "Manufacturer3", Cost = 500 },
                new Device { Name = "Device6", Manufacturer = "Manufacturer3", Cost = 600 }
            };


            var difference = GetDifference(devices1, devices2);
            Console.WriteLine("Difference:");
            PrintDevices(difference);

            var intersection = GetIntersection(devices1, devices2);
            Console.WriteLine("Intersection:");
            PrintDevices(intersection);

            var union = GetUnion(devices1, devices2);
            Console.WriteLine("Union:");
            PrintDevices(union);
        }




        public static Device[] GetDifference(Device[] devices1, Device[] devices2)
        {
            var result = new List<Device>();
            foreach (var device in devices1)
            {
                if (!devices2.Any(d => d.Manufacturer == device.Manufacturer))
                {
                    result.Add(device);
                }
            }

            foreach (var device in devices2)
            {
                if (!devices1.Any(d => d.Manufacturer == device.Manufacturer))
                {
                    result.Add(device);
                }
            }

            return result.ToArray();
        }

        public static Device[] GetIntersection(Device[] devices1, Device[] devices2)
        {
            var result = new List<Device>();
            foreach (var device in devices1)
            {
                if (devices2.Any(d => d.Manufacturer == device.Manufacturer))
                {
                    result.Add(device);
                }
            }

            foreach (var device in devices2)
            {
                if (devices1.Any(d => d.Manufacturer == device.Manufacturer))
                {
                    result.Add(device);
                }
            }

            return result.ToArray();
        }

        public static Device[] GetUnion(Device[] devices1, Device[] devices2)
        {
            var result = new List<Device>();
            foreach (var device in devices1)
            {
                result.Add(device);
            }

            foreach (var device in devices2)
            {
                if (!devices1.Any(d => d.Manufacturer == device.Manufacturer))
                {
                    result.Add(device);
                }
            }

            return result.ToArray();
        }

        public static void PrintDevices(Device[] devices)
        {
            foreach (var device in devices)
            {
                Console.WriteLine($"Name: {device.Name}, Manufacturer: {device.Manufacturer}, Cost: {device.Cost}");
            }
        }
    }
}
