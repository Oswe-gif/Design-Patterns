using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Windows
{
    internal class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
