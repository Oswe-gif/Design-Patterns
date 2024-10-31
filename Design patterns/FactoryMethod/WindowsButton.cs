using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class WindowsButton : Button
    {
        public void onClick(string click)
        {
            Console.WriteLine("WindowsButton: "+ click);
        }

        public void Render()
        {
            Console.WriteLine("Render a Windows Button");
        }
    }
}
