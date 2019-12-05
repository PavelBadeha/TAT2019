using System;

namespace Dev_6
{
    /// <summary>
    /// Class of client manager that helps the client
    /// </summary>
    class ClientManager:Invoker
    {
        private CarShowroom carShowroom;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="carShowroom"></param>
        public ClientManager(CarShowroom carShowroom)
        {
            this.carShowroom = carShowroom;
        }

        /// <summary>
        /// Method that can set list of the cars using the client
        /// </summary>
        public void SetListOfCars()
        {
            string brand;
            string model;
            int price;
            int amount;

            while (true)
            {
                Console.WriteLine("Input brand");
                brand = Console.ReadLine();

                Console.WriteLine("Input model");
                model = Console.ReadLine();

                Console.WriteLine("Input price");
                int.TryParse(Console.ReadLine(), out price);

                Console.WriteLine("Input amount");
                int.TryParse(Console.ReadLine(), out amount);
                carShowroom.SetListOfCars(new Car(brand, model, price), amount);

                Console.WriteLine("More cars?Y/N");

                if (Console.ReadLine() == "N")
                {
                    Console.Clear();
                    break;
                }
            }
        }

        /// <summary>
        /// Method allows client to select a command
        /// </summary>
        public void ChooseCommand()
        {
            Console.WriteLine("(1)Count types\n(2)AveragePrice\n(3)AveragePriceType\n(4)Count all\n(5)Exit");
            Commands command;
            while (true)
            {                
                Console.WriteLine("Input command that u need");
                Enum.TryParse(Console.ReadLine(), out command);

                switch (command)
                {
                    case Commands.AveragePrice:
                        SetCommand(new AveragePriceCommand(carShowroom));
                        Run();
                        break;

                    case Commands.AveragePriceType:
                        Console.WriteLine("Input brand");
                        SetCommand(new AveragePriceTypeCommand(carShowroom, Console.ReadLine()));
                        Run();
                        break;

                    case Commands.CountAll:
                        SetCommand(new CountAllCommand(carShowroom));
                        Run();
                        break;

                    case Commands.CountTypes:
                        SetCommand(new CountTypesCommand(carShowroom));
                        Run();
                        break;
                    case Commands.Exit:
                        SetCommand(new ExitCommand());
                        Run();
                        break;
                    default:
                        Console.WriteLine("Incorrect command");
                        break;
                }
            }
        }
    }
}
