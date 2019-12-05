namespace Dev_6
{
    /// <summary>
    /// Class of entry point
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method
        /// </summary>
        static void Main()
        {
            CarShowroom carShowroom = new CarShowroom();

            ClientManager clientManager = new ClientManager(carShowroom);

            clientManager.SetListOfCars();
            clientManager.ChooseCommand();
        }
    }
}
