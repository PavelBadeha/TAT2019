using System.Collections.Generic;
using System.Linq;

namespace Dev_6
{
    /// <summary>
    /// Class of car showroom
    /// </summary>
    class CarShowroom
    {
        /// <summary>
        /// Lisr of cars
        /// </summary>
        public List<Car> Cars { get;} = new List<Car>();

        /// <summary>
        /// Method that allows set the list of cars
        /// </summary>
        /// <param name="car"></param>
        /// <param name="amount"></param>
        public void SetListOfCars(Car car, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Cars.Add(car);
            }
        }

        /// <summary>
        /// Method that returns the count of brands
        /// </summary>
        /// <returns></returns>
        public int GetCountTypes()
        {
            return Cars.Select(x => x.Brand).Distinct().Count();
        }

        /// <summary>
        /// Method that returns the count of all cars
        /// </summary>
        /// <returns></returns>
        public int GetCountAll()
        {
            return Cars.Count;
        }

        /// <summary>
        /// Method that returns the average price of cars
        /// </summary>
        /// <returns></returns>
        public double GetAveragePrice()
        {
            return Cars.Select(x => x.Price).Average();
        }

        /// <summary>
        /// Method that rerurns the average price of special brand of cars
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public double GetAveragePriceType(string brand)
        {
            if (Cars.Any(x => x.Brand == brand))
            {
                return Cars.Where(x => x.Brand == brand).Select(x => x.Price).Average();
            }
            else
            {
                throw new NoSuchCarInCarShowroomException(); 
            }
        }
    }
}
