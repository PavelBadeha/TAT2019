using System;

namespace CW_5
{
    /// <summary>
    /// Class of entry point
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method
        /// </summary>
        static void Main()
        {
            try
            {
                TransportOrganization parking = new TransportOrganization();
                Bus bus = new Bus(new Chassis(4, 100, 10),
                                  new Engine(100, 2, "dizel", 20),
                                  new Transmission("ZL1", 4, "GomSelmash"),
                                  75);
                Car car = new Car(new Chassis(4, 50, 5),
                                  new Engine(76, 1, "petrol", 20),
                                  new Transmission("ZL3", 5, "GomSelmash"),
                                  "Audi");
                Scooter scooter = new Scooter(new Chassis(2, 79, 3),
                                              new Engine(30, 0.5f, "petrol", 21),
                                              new Transmission("ZL5", 3, "GomSelmash"),
                                              1000f);
                Truck truck = new Truck(new Chassis(4, 101, 50),
                                        new Engine(200, 3, "dizel", 105),
                                        new Transmission("ZL9", 6, "GomSelmash"),
                                        10000f);

                parking.Transports.Add(car);
                parking.Transports.Add(bus);
                parking.Transports.Add(scooter);
                parking.Transports.Add(truck);

                parking.DisplayInfoAboutBusAndTrucksEngine();
                parking.DisplayInfoAboutTransportsWithEngineCapacityMore(1.5f);
                parking.DisplayInfoAboutTrnasportsOrderByTransmissionType();
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
