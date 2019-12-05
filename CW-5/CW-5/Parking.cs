using System;
using System.Collections.Generic;
using System.Linq;

namespace CW_5
{
    class Parking
    {
        public List<Transport> Transports { get; set; } = new List<Transport>();
        public void DisplayInfoAboutTransportsWithEngineCapacityMore(float engineCapacity)
        {
            if(CheckForEmpty())
            {
                Console.WriteLine(string.Join("\n", Transports.Where(x => x.Engine.Capacity > engineCapacity).
                                                          Select(x => x.ToString()).
                                                          ToArray()));
            }          
        }
        public void DisplayInfoAboutBusAndTrucksEngine()
        {
            if(CheckForEmpty())
            {
                Console.WriteLine(string.Join("\n", Transports.Where(x => x is Bus || x is Truck).
                                                        Select(x => x.Engine.ToString()).
                                                        ToArray()));
            }          
        }
        public void DisplayInfoAboutTrnasportsOrderByTransmissionType()
        {
            if(CheckForEmpty())
            {
                Console.WriteLine(string.Join("\n", Transports.OrderBy(x => x.Transmission.Type).
                                                          Select(x => x.ToString()).
                                                          ToArray()));
            }            
        }
        private bool  CheckForEmpty()
        {
            return Transports.Count > 0;
        }
    }
}
