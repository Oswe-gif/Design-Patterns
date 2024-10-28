using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Windows
{
    internal class WinCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("Windows Checkbox");
        }
    }
}
