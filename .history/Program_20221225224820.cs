

Stack<Char> mStack = new Stack<char>();

mStack.Push('(');
mStack.Push('+');
mStack.Push(')');

foreach (var item in mStack)
{   
   while(i < mStack)
     Console.WriteLine("item at " + mStack.ElementAt(item) + item 
    );
}