using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema8w7
{
    internal class Train
    {
        private string name;
        private Locomotive locomotive;
        private List<Wagon> wagons = new List<Wagon>();

        public Train(string name, Locomotive locomotive)
        {
            this.name = name;
            this.locomotive = locomotive;
        }

        public void AddWagon(Wagon wagon)
        {
            this.wagons.Add(wagon);
        }


        public void LeaveStation()
        {
            Console.WriteLine($"train {name} is leaving the station");

            for (int i = 0; i < wagons.Count; i++)
            {
                Console.Write($"wagon {i}: ");
                var wagon = wagons[i];
                if (wagon is FreightWagon)
                {
                    Console.WriteLine();
                    continue;
                }
                if (wagon is PersonsWagonFirstClass)
                {
                    var asPersons = wagon as PersonsWagonFirstClass;
                    asPersons.CloseDoors();
                    asPersons.StartAC();
                    continue;
                }
                if (wagon is PersonsWagon)
                {
                    var asPersons = wagon as PersonsWagon;

                    asPersons.CloseDoors();
                }
            }

            this.locomotive.Start();
        }

        public void ArriveAtStation()
        {
            Console.WriteLine($"train {name} is arriving at the station");
            this.locomotive.Stop();

            for (int i = 0; i < wagons.Count; i++)
            {
                Console.Write($"wagon {i}: ");
                var wagon = wagons[i];
                if (wagon is FreightWagon)
                {
                    Console.WriteLine();
                    continue;
                }
                if (wagon is PersonsWagonFirstClass)
                {
                    var asPersons = wagon as PersonsWagonFirstClass;
                    asPersons.StopAC();
                    asPersons.OpenDoors();
                    continue;
                }
                if (wagon is PersonsWagon)
                {
                    var asPersons = wagon as PersonsWagon;

                    asPersons.OpenDoors();
                }
            }
        }

        public int SeatsCount
        {
            get
            {
                int seatsCount = 0;

                foreach (var wagon in wagons)
                {
                    var asPersons = wagon as PersonsWagon;

                    if (asPersons != null)
                    {
                        seatsCount += asPersons.SeatsCount;
                    }
                }

                return seatsCount;
            }
        }

        public List<CargoSummary> GetCargoSummary()
        {
            var steel = new CargoSummary(CargoType.Steel);
            var coal = new CargoSummary( CargoType.Coal);
            var grain = new CargoSummary( CargoType.Grain);

            foreach (var wagon in wagons)
            {
                var asCargo = wagon as FreightWagon;
                if (asCargo == null)
                {
                    continue;
                }
                switch (asCargo.CargoType)
                {
                    case CargoType.Grain:
                        grain.Capacity += asCargo.Capacity;
                        break;
                    case CargoType.Steel:
                        steel.Capacity += asCargo.Capacity;
                        break;
                    case CargoType.Coal:
                        coal.Capacity += asCargo.Capacity;
                        break;
                }
            }

            return new List<CargoSummary> { steel, coal, grain };
        }
    }
}

