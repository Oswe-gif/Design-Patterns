using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car : CarSchema
    {
        public float Price { get; set; }
        public Car(int id, string brand, string model, string color, float price)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Price = price;
        }

        public override string ToString()
        {
            return "id: " + Id + " brand: "+Brand + " model: "+Model + " color: "+Color + " price : "+Price ;
        }
    }
}
