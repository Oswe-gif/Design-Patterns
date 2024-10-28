using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MacOS
{
    internal class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
