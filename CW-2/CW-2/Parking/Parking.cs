using System.Collections.Generic;
using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of parking
    /// </summary>
    class Parking:Department
    {
        #region Propierties
        /// <summary>
        /// Head of parking
        /// </summary>
        [JsonProperty]
        public Head Head { get; private set; } =new Head();

        /// <summary>
        /// List of garages in parking
        /// </summary>
        [JsonProperty]
        public List<Garage> Garages { get; private set; } = new List<Garage>();

        /// <summary>
        /// List of car
        /// </summary>
        [JsonProperty]
        public List<Car> Cars { get; private set; } = new List<Car>();
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Parking() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of parking</param>
        /// <param name="head">Head of parking</param>
        /// <param name="address">Address of parking</param>
        public Parking(string name, Head head, Address address) : base(name, address)
        {
            Head = head;
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of parking</param>
        /// <param name="head">Head of parking</param>
        /// <param name="garages">List of garages in parking</param>
        /// <param name="cars">List of cars in parking</param>
        /// <param name="address">Address of parking</param>
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
        #endregion

        #region Methods
        /// <summary>
        /// Method that can add car to list of cars
        /// </summary>
        /// <param name="car">Car which needed to add</param>
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        /// <summary>
        /// Method that can add garage to list of garages
        /// </summary>
        /// <param name="garage">Garage which needed to add</param>
        public void AddGarage(Garage garage)
        {
            Garages.Add(garage);
        }

        /// <summary>
        /// Method that can add list of cars 
        /// </summary>
        /// <param name="cars">List of car which needed to add</param>
        public void AddCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                AddCar(car);
            }
        }

        /// <summary>
        /// Method that can add list of garages
        /// </summary>
        /// <param name="garages">Garage which needed to add</param>
        public void AddGarages(List<Garage> garages)
        {
            foreach (var garage in garages)
            {
                AddGarage(garage);
            }
        }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the parking.</returns>
        public override string ToString()
        {
            return "Parking " +base.ToString() + "\n"+ Head + "\n" +"Quantity of garages:" + Garages.Count + " Quantity of cars:"+Cars.Count;
        }
        #endregion
    }
}
