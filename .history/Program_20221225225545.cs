
/*
    Stack metjod
    Stack.Push() // Insert an item at the top of the stack
    Peek()
*/

Stack<Char> mStack = new Stack<char>();

mStack.Push('(');
mStack.Push('+');
mStack.Push(')');

foreach (var item in mStack)
{   
    Console.WriteLine("item = " + item );
}