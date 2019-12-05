using System;

namespace Dev_6
{
    /// <summary>
    /// Class of the count all command
    /// </summary>
    class CountAllCommand : ICommand
    {
        private CarShowroom _carShowroom;

        public CountAllCommand(CarShowroom carShowroom)
        {
            _carShowroom = carShowroom;
        }
        public void Execute()
        {
            Console.WriteLine(_carShowroom.GetCountAll());
        }
        public void Undo()
        {

        }
    }
}
