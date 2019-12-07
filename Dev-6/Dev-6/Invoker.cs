namespace Dev_6
{
    /// <summary>
    /// Class of invoker
    /// </summary>
    class Invoker
    {
        private ICommand _command;

        /// <summary>
        /// Method that sets the command
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Method that runs the command
        /// </summary>
        public void Run()
        {
            _command?.Execute();
        }
    }
}
