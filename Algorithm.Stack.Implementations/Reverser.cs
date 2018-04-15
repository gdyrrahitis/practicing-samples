namespace Algorithm.Stack.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Reverser
    {
        private readonly string _input;

        public Reverser(string input)
        {
            _input = input;
        }

        public string Reverse()
        {
            var stack = new Stack<char>();
            foreach (var ch in _input)
            {
                stack.Push(ch);
            }

            var builder = new StringBuilder();
            while (stack.Any())
            {
                builder.Append(stack.Pop());
            }

            return builder.ToString();
        }
    }
}