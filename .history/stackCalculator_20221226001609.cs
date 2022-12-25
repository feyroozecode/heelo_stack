
namespace Calc{
    class Calc{
        string testOp = "(4+3) + (7-5)";

    }

    // fun evalate user input inscrutction (e.g): (47-5) + (9*3) 
    // YOu need to understanding first the c# Stack for 
    // GEt to this method
    static int eval(String input){
        Stack<int> values = new Stack<int>();
        Stack<char> operators = new Stack<char>();

        for(int i =0; i < input.Length; i++){

            // 
            char c = input[i];

            if(c == ' ') continue;

            if(c == 'C'){
                operators.Push(c);
            }
            else if(c == ')' ) { // end of instruction inside ()
                
                // when operator of top item in the stack is not 'C'
                while(operators.Peek() != 'C'){ // 
                    int a = values.Pop(); // remove and returns top item in the stack
                    int b = values.Pop(); // '''''''''''

                    char op = operators.Pop(); // ''''

                    values.Push(ApplyOp(b, a, op));
                }  
            }
            // else if operand is expression and != ( or ) e.g: new expression,
            else if(c == '+' || c == '-' || c == '*' || c == '/'){
                
                // when operators stack is not empty in the total inscruction and has precedent operation
                while(
                    operators.Count > 0 && hasPrecedence(c, operators.Peek())
                    ){
                        int a = values.Pop(); // remove a and return top stack item
                        int b = values.Pop(); // ''''
                        char op = operators.Pop();
                        values.Push(ApplyOp(b, a, op)); // insert result 
                    }
            }
        }
        
        // Get if precedente operation exist vefore new oper
        static bool hasPrecedence(char op1, char op2){
            if(op2 == '(' || op2 == ')') return false;
            if((op1 == '*' || op2 == '/') &&  (op2 == '+' || op2 == '-'));
            return true;
        }

        // apply Operation
        static int ApplyOp(int b, int a, char op){

            switch(op){
                case '+': return a+b;
                case '-': return a-b;
                case '*': return a*b;
                case '/': return a/b;
            }

        return 0;  
        }

}