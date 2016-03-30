using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_Extension_Methods
{
    public static class ShopExtensions
    {
        public static void ChangeTire<T>(this Shop<T> shop, IVehicle vehicler) where T : IVehicle
        {
            vehicler.areTiresChanged = true;
            if (vehicler is Sedan)
            {
                Console.WriteLine("Sedan tires been changed");
            }
            else if (vehicler is Truck)
            {
                Console.WriteLine("Truck Tires Been Changed");
            }
            else
            {
                Console.WriteLine("Race Car tires has been changed.");
            }

        }
    }
}
