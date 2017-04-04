namespace Patterns.Command
{
    using System.Collections.Generic;
    using System.Linq;
    using Commands;

    public class CalculatorActiveObject
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public void Push(ICommand command)
        {
            _commands.Push(command);
        }

        public int Calculate() => _commands.Sum(command =>
        {
            command.Do();
            return command.Number;
        });

        public void Pop()
        {
            _commands.Pop();
        }
    }
}