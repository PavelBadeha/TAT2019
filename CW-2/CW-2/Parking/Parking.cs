using System.Collections.Generic;

namespace CW_2
{
    class Parking:Department
    {
        public Head Head { get; }=new Head();

        public List<Garage> Garages { get; }= new List<Garage>();

        public List<Car> Cars { get; } = new List<Car>();

        public Parking() { }

        public Parking(Head head, List<Garage> garages, List<Car> cars,Address address):base(address)
        {
            Head = head;
            Garages = garages;
            Cars = cars;
        }

        public void AddGarage(Garage garage)
        {
            Garages.Add(garage);
        }
        public override string ToString()
        {
            return "Parking\n"+base.ToString() + " Quantity of garages:" + Garages.Count + " Quantity of cars:"+Cars.Count;
        }
    }
}
