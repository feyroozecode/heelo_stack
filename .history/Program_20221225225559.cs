
/*
    Stack metjod
    Stack.Push() // Insert an item at the top of the stack
    Peek(): Returns the top item from the stack
    Pop():
*/

Stack<Char> mStack = new Stack<char>();

mStack.Push('(');
mStack.Push('+');
mStack.Push(')');

foreach (var item in mStack)
{   
    Console.WriteLine("item = " + item );
}