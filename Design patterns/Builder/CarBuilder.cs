using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarBuilder : Builder
    {
        private int id;
        private string brand;
        private string model;
        private string color;
        private float price;

        public Builder Brand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public Builder Color(string color)
        {
            this.color = color;
            return this;
        }

        public Builder Id(int id)
        {
            this.id = id;
            return this;
        }

        public Builder Model(string model)
        {
            this.model = model;
            return this;
        }

        public CarSchema Build() {
            return new Car(this.id, this.brand, this.model, this.color, this.price);
        }
    }
}
