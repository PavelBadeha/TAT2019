namespace Dev_6
{
    /// <summary>
    /// Class of car
    /// </summary>
    class Car
    {
        /// <summary>
        /// Brand of the car
        /// </summary>
        public string Brand { get; } = string.Empty;

        /// <summary>
        /// Model of the car
        /// </summary>
        public string Model { get; } = string.Empty;

        private int _price;

        /// <summary>
        /// Price of the car
        /// </summary>
        public int Price
        {
            get
            {
                return _price;
            }
            private set
            {
                if(value > 0)
                {
                    _price = value;
                }
            }
        }
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="brand">Brand of the car</param>
        /// <param name="model">Model of the car</param>
        /// <param name="price">Price of the car</param>
        public Car(string brand,string model,int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
    }
}
