using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface Builder
    {
        public Builder Id(int id);
        public Builder Brand(string brand);
        public Builder Model(string model);
        public Builder Color(string color);
        public CarSchema Build();
    }
}
