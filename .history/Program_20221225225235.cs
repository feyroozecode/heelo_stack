

Stack<Char> mStack = new Stack<char>();

mStack.Push('(');
mStack.Push('+');
mStack.Push(')');

foreach (var item in mStack)
{   
    var i = mStack.ElementAt(item)-1;

    Console.WriteLine("item at " + i + item );
}