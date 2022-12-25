
/*
    Stack metjod
    Stack.Push() // Insert an item at the top of the stack
    Peek(): Returns the top item from the stack
    Pop(): Remove and returns items form the top of the stack
    Contains(T): Check whether an item exist in the stack or not
    Clear(): Removes items from the stack
*/

Stack<Char> mStack = new Stack<char>();

mStack.Push('(');
mStack.Push('+');
mStack.Push(')');

foreach (var item in mStack)
{   
    Console.WriteLine("item: {0}", item );
}


void removeStack(Stack<Char> st){
    if(st.Count > 0){
        
    }
}