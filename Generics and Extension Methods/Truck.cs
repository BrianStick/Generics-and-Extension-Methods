using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_Extension_Methods
{
    public class Truck : TheVehicle
    {
        public Truck()
        {
            AreTiresChanged = true;
            IsFilledUp = true;
            IsNewOil = true;
            TypeOfGas = GasType.Diesel;
        }

        public override string ToString()
        {
            return "Truck";
        }
    }
}
