using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_9
{
    class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;

        public Flash(string name, string model, double usbSpeed, double memorySize)
            : base(name, model)
        {
            this.usbSpeed = usbSpeed;
            this.memorySize = memorySize;
        }

        public override double GetMemory()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to Flash memory. Size: {dataSize} GB, Speed: {usbSpeed} MB/s");
        }

        public override double GetFreeMemory()
        {
            return memorySize * 0.9;
        }

        public override string GetDeviceInfo()
        {
            return $"Flash Memory - Name: {Name}, Model: {Model}, USB Speed: {usbSpeed} MB/s, Memory Size: {memorySize} GB";
        }
    }
}
