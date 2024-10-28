using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Windows
{
    internal class WinButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("Windows Button");
        }
    }
}
