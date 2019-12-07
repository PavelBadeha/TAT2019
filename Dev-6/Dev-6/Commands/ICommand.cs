
namespace Dev_6
{
    /// <summary>
    /// Interface of commands
    /// </summary>
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
