
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

getLastAdded(mStack);
getIfExist(mStack, ')');

void getLastAdded(Stack<Char> st){
    if(st.Count > 0){
        Console.WriteLine("Last added is {0}", st.Peek());
    }
}

bool getIfExist(Stack<Char> st, Char el){

    if(st.Contains(el))
        Console.WriteLine("ELement exist on {0}", st , " at position ");
        return true;

    return false;    
}