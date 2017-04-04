namespace Patterns.Command.Commands
{
    public interface ICommand
    {
        int Number { get; }
        void Do();
        void Undo();
    }
}