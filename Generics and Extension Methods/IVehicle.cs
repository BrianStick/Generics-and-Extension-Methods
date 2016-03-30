using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_Extension_Methods
{

    public class TheVehicle
    {
        public bool IsNewOil { get; set; }
        public bool AreTiresChanged { get; set; }
        public bool IsFilledUp { get; set; }

        public enum GasType
        {
            Regular,
            Diesel,
            HighPerformance
        }

        public GasType TypeOfGas { get; set; }


    }
}
