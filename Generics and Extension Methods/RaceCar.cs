using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_Extension_Methods
{
    class RaceCar: IVehicle
    {
        public class RaceCar : TheVehicle
        {
            public RaceCar()
            {
                AreTiresChanged = true;
                IsFilledUp = true;
                IsNewOil = true;
                TypeOfGas = GasType.HighPerformance;
            }

            public override string ToString()
            {
                return "Race Car";
            }
        }
}
