
namespace Calc{
    class Calc{
        string testOp = "(4+3) + (7-5)";

    }

    static double eval(String input){
        Stack<double> values = new Stack<double>();
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
                    double a = values.Pop(); // remove and returns top item in the stack
                    double b = values.Pop(); // '''''''''''

                    char op = operators.Pop(); // ''''

                    values.Push(ApplyOper(b, a, op));
                }  
            }
        }

        static bool hasPrecedence(char op1, char op2){
            if(op2 == '(' || op2 == ')') return false;
            if((op1 == '*' || op2 == '/') && ) return false;
            return true;
        }

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
}