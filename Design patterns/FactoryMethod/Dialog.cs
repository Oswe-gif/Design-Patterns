using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Dialog
    {
        public abstract Button CreateButton();

        public void Render() { 
            Button okButton = CreateButton();
            okButton.onClick("Hi there!");
            okButton.Render();
        }
    }
}
