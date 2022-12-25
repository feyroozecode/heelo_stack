

Stack<Char> mStack = new Stack<char>();

mStack.Push('(');
mStack.Push('+');
mStack.Push(')');

foreach (var item in mStack)
{   
    var i = mStack.ElementAt(item)
    Console.WriteLine("item at " + mStack.ElementAt + item 
    );
}