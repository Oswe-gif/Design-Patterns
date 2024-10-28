using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    internal class MacCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("Mac Checkbox");
        }
    }
}
