using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Laptop
    {
        public int screen;
        public string memory;
        private string ram;  //private

        public Laptop(int screenSize, string memoryType)
        {
            screen = screenSize;
            memory = memoryType;
        }

        public void setValue(string ramMemory)
        {
            ram = ramMemory;            
        }

        public string getValue()
        {
            return ram;
        }

    }
}
