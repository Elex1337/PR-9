using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_9
{
    abstract class Storage
    {
        private string name;
        private string model;

        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        public string Name { get { return name; } }
        public string Model { get { return model; } }

        public abstract double GetMemory();
        public abstract void CopyData(double dataSize);
        public abstract double GetFreeMemory();
        public abstract string GetDeviceInfo();
    }

}
