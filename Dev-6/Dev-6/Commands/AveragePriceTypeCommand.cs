using System;

namespace Dev_6
{
    /// <summary>
    /// Class of the average price of the special brand command
    /// </summary>
    class AveragePriceTypeCommand : ICommand
    {
        private CarShowroom _carShowroom;
        private string _brand = string.Empty;
        public AveragePriceTypeCommand(CarShowroom carShowroom,string brand)
        {
            _carShowroom = carShowroom;
            _brand = brand;
        }
        public void Execute()
        {
            try
            {
                Console.WriteLine(_carShowroom.GetAveragePriceType(_brand));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Undo()
        {

        }
    }
}
