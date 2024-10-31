using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface Button
    {
        public void Render();
        public void onClick(string click);
    }
}
