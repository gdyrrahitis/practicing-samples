# Stack implementations
Stack provides is a FIFO structure, that means it can be extremely useful in cases where you want to store data in such order and then retrieve that data in the reverse order that you added it.

## Reversing a string
This implementation uses the FIFO power.

Steps for the algorithm:
1. Insert each character in the stack
2. Pop each character from the stack until it is empty
3. Store each popped character to a string
4. Return the string

## Checking opening and closing brackets
Another useful implementation is the one that helps to verify is closing brackets meet their match.
With a stack implementation, you can push each opening bracket into the stack, while looping through the string. If you find a closing bracket in the way, you can pop the last opened bracket from the stack. If it matches, success, else you can return an error.

Sample implementation:
```
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
```