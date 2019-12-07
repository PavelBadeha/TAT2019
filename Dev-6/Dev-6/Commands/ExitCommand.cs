using System;

namespace Dev_6
{
    /// <summary>
    /// Class of the exit command
    /// </summary>
    class ExitCommand:ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
        public void Undo()
        {

        }
    }
}
