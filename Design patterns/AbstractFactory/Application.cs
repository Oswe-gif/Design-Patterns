using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Application
    {
        private GUIFactory _factory;
        private Button _button;
        private Checkbox _checkbox;

        public Application(GUIFactory factory)
        {
            _factory = factory;
        }
        public void CreateUI() { 
            _button = _factory.CreateButton();
            _checkbox = _factory.CreateCheckbox();
        }
        public void Paint() { 
            _button.Paint();
            _checkbox.Paint();
        }
    }
}
