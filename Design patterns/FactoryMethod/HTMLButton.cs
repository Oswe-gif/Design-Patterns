using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class HTMLButton : Button
    {
        public void onClick(string click)
        {
            Console.WriteLine("HTML button: "+click);
        }

        public void Render()
        {
            Console.WriteLine("Render a HTML button");
        }
    }
}
