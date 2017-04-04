namespace Patterns.Command.Commands
{
    public class AddCommand: ICommand
    {
        private readonly int _number;

        public AddCommand(int number)
        {
            _number = number;
        }

        public int Number { get; private set; }

        public void Do() => Number += _number;

        public void Undo() => Number -= _number;
    }
}