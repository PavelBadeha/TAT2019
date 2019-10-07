using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace CW_2
{
    class Parking:Department
    {
        public Head Head { get; }=new Head();

        public List<Garage> Garages { get; }= new List<Garage>();

        public List<Car> Cars { get; } = new List<Car>();

        public Parking() { }

        public Parking(string name, Head head, Address address) : base(name, address)
        {
            Head = head;
        }
        public Parking(string name,Head head, List<Garage> garages, List<Car> cars,Address address):base(name,address)
        {
            Head = head;
            foreach (var garage in garages)
            {
                AddGarage(garage);
            }

            foreach (var car in cars)
            {
                AddCar(car);
            }
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void AddGarage(Garage garage)
        {
            Garages.Add(garage);
        }

        public override string ToString()
        {
            return "Parking " +base.ToString() + "\n"+ Head + "\n" +"Quantity of garages:" + Garages.Count + " Quantity of cars:"+Cars.Count;
        }
    }
}
