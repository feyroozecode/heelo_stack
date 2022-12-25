

Stack<Char> mStack = new Stack<char>();

mStack.Push('(');
mStack.Push('+');
mStack.Push(')');

foreach (var item in mStack)
{   
   int i = mStack.Count-1; 
   while(mStack.Count-1)
     Console.WriteLine("item at " + mStack.ElementAt(item) + item 
    );
}