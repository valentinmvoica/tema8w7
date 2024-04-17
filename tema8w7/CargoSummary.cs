using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema8w7
{
    internal class CargoSummary
    {
        public double Capacity { get; set; } = 0;
        public CargoType CargoType { get; set; }
        public CargoSummary(CargoType cargoType)
        {
            CargoType = cargoType;  
        }
    }
}
