using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    internal class MacButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("Mac Button");
        }
    }
}
