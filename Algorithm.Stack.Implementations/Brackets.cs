namespace Algorithm.Stack.Implementations
{
    using System.Collections.Generic;

    public class Brackets
    {
        private readonly string _expression;

        public Brackets(string expression)
        {
            _expression = expression;
        }

        public bool Check()
        {
            var stack = new Stack<char>();
            foreach (var ch in _expression)
            {
                switch (ch)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(ch);  
                        break;
                    case '}':
                    case ']':
                    case ')':
                        var stored = stack.Pop();
                        if (ch == '}' && stored == '{' ||
                            ch == ']' && stored == '[' ||
                            ch == ')' && stored == '(')
                            continue;
                        return false;
                }
            }

            return true;
        }
    }
}