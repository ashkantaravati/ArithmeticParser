using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticParser
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)//going to use postfix -- UPDATE: it works with all notations!
            {
                Console.WriteLine("enter arithmetic expresseions. Separate operators and operands using space");
            string input = "";
            Stack<string> operatorStack = new Stack<string>();
            Stack<string> operandStack = new Stack<string>();
            input = Console.ReadLine();
            var arr= input.Split(' ');

                for (int i=arr.Count()-1;i>=0;i--)
                {
                    if (isNumber(arr[i]))
                        operandStack.Push(arr[i]);
                    else if (isOperator(arr[i]))
                        operatorStack.Push(arr[i]);
                    else
                    {
                        Console.WriteLine("enter correct values");
                        continue;
                    }
                }
                int result = 0;
                //TODO: loop start
                while (operatorStack.Count != 0)
                {
                    int op1 = int.Parse(operandStack.Pop());
                    int op2 = int.Parse(operandStack.Pop());

                    char oper = operatorStack.Pop().ToCharArray()[0];
                    switch (oper)
                    {
                        case '+':
                            result = op1 + op2;
                            break;
                        case '-':
                            result = op1 - op2;
                            break;
                        case '*':
                            result = op1 * op2;
                            break;
                        case '/':
                            result = op1 / op2;
                            break;


                            
                    }
                    operandStack.Push(result.ToString());
                }
                    Console.WriteLine(result.ToString());
                        //loop end



                
            }
        }
        public static bool isNumber(string input)
        {
            var ch = input.ToCharArray()[0];
            //if (ch >= 0xfeff0030 && ch <= 0xfeff0039)
            //    return true;
            //else
            //    return false;
            if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
                return true;
            else
                return false;





               }
        public static bool isOperator(string input)
        {

            var ch = input.ToCharArray()[0];
            //if (ch >= 0xfeff0028 && ch <= 0xfeff002f)
            //    return true;
            //else
            //    return false;
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/'
                //|| ch == '(' || ch == ')' || ch == '^' 
                )
                return true;
            else
                return false;

        }
        //static void Split()
        //{
        //    string 
        //}
    }

}
