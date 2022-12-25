
namespace Calc{
    class Calc{
        string testOp = "(4+3) + (7-5)";

    }

    static double eval(String input){
        Stack<double> values = new Stack<double>();
        Stack<double> operators = new Stack<double>();

        for(int i =0; i < input.Length; i++){

            // 
            char c = input[i];

            if(c == ' ') continue;

            if(c == 'C'){
                operators.Push(c);
            }
            else if(c == ')' ) { // end of 
                while()
            }
        }

    }
}