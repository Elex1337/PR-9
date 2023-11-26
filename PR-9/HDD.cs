using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_9
{
    class HDD : Storage
    {
        private double usbSpeed;
        private int partitions;
        private double partitionSize;

        public HDD(string name, string model, double usbSpeed, int partitions, double partitionSize)
            : base(name, model)
        {
            this.usbSpeed = usbSpeed;
            this.partitions = partitions;
            this.partitionSize = partitionSize;
        }

        public override double GetMemory()
        {
            return partitions * partitionSize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to Removable HDD. Size: {dataSize} GB, Speed: {usbSpeed} MB/s");
        }

        public override double GetFreeMemory()
        {
            return GetMemory() * 0.95;
        }

        public override string GetDeviceInfo()
        {
            return $"Removable HDD - Name: {Name}, Model: {Model}, USB Speed: {usbSpeed} MB/s, Partitions: {partitions}, Partition Size: {partitionSize} GB";
        }
    }
}
