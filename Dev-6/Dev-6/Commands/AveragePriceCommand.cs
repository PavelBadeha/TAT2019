using System;

namespace Dev_6
{
    /// <summary>
    /// Class of the average price command
    /// </summary>
    class AveragePriceCommand : ICommand
    {
        private CarShowroom _carShowroom;

        public AveragePriceCommand(CarShowroom carShowroom)
        {
            _carShowroom = carShowroom;
        }
        public void Execute()
        {
            Console.WriteLine(_carShowroom.GetAveragePrice());
        }
        public void Undo()
        {

        }
    }
}
