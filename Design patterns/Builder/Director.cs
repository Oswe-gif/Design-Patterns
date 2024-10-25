using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        public void BuildBugatti(Builder builder) {
            builder.Brand("Bugatti")
                    .Color("Blue")
                    .Build();
        }

        public void buildLambo(Builder builder) { 
            builder.Brand("Lamborghini")
                   .Model("Aventador")
                   .Build();
        }
    }
}
