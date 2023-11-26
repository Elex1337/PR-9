using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_9
{
    class DVD : Storage
    {
        private double readWriteSpeed;
        private bool doubleLayer;

        public DVD(string name, string model, double readWriteSpeed, bool doubleLayer)
            : base(name, model)
        {
            this.readWriteSpeed = readWriteSpeed;
            this.doubleLayer = doubleLayer;
        }

        public override double GetMemory()
        {
            return doubleLayer ? 9 : 4.7;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to DVD. Size: {dataSize} GB, Speed: {readWriteSpeed} MB/s");
        }

        public override double GetFreeMemory()
        {
            return 0;
        }

        public override string GetDeviceInfo()
        {
            return $"DVD Disk - Name: {Name}, Model: {Model}, Read/Write Speed: {readWriteSpeed} MB/s, Type: {(doubleLayer ? "Double Layer" : "Single Layer")}";
        }
    }
}
