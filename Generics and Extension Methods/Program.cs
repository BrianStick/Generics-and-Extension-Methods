using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var OneStop = new Shop<Sedan>();
            var TwoStop = new Shop<RaceCar>();
            var ThreeStop = new Shop<Truck>();
            var truck = new Truck();
            var raceCar = new RaceCar();
            var sedan = new Sedan();
            List<TheVehicle> ThreeVehicles = new List<TheVehicle> { truck, raceCar, sedan };

            ThreeStop.IsNewOil(truck);
            ThreeStop.isFilledUp(truck);
            ThreeStop.AreTiresChanged(truck);
            Console.WriteLine();

            TwoStop.IsNewOil(raceCar);
            TwoStop.isFilledUp(raceCar);
            TwoStop.AreTiresChanged(raceCar);
            Console.WriteLine();

            OneStop.IsNewOil(sedan);
            OneStop.isFilledUp(sedan);
            OneStop.AreTiresChanged(sedan);
            Console.WriteLine();

            Console.ReadLine();
        }
    }



}


