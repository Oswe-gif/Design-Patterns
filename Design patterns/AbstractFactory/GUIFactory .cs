﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface GUIFactory
    {
        public Button CreateButton();
        public Checkbox CreateCheckbox();
    }
}
