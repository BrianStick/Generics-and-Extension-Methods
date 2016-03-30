using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_Extension_Methods
{
    class Sedan: IVehicle
    {
        public class Sedan : TheVehicle
        {
            public Sedan()
            {
                AreTiresChanged = true;
                IsNewOil = true;
                IsFilledUp = true;
                TypeOfGas = GasType.Regular;
            }

            public override string ToString()
            {
                return "Sedan";
            }

        }
}
