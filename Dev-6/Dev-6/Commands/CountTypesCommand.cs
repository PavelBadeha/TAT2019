using System;

namespace Dev_6
{
    /// <summary>
    /// Class of the count types command
    /// </summary>
    class CountTypesCommand:ICommand
    {
        private CarShowroom _carShowroom;

        public CountTypesCommand(CarShowroom carShowroom)
        {
            _carShowroom = carShowroom;
        }
        public void Execute()
        {
           Console.WriteLine(_carShowroom.GetCountTypes());
        }
        public void Undo()
        {

        }
    }
}
