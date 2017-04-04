namespace Patterns.Command.Commands
{
    public class SubtractCommand: ICommand
    {
        private readonly int _number;

        public SubtractCommand(int number)
        {
            _number = number;
        }

        public int Number { get; private set; }

        public void Do() => Number -= _number;

        public void Undo() => Number += _number;
    }
}