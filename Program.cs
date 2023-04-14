using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR_WITH_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define inputs

            float firstnumber, secondnumber;
            char op;
            float result = 0;

            //accept values from user

            Console.WriteLine("Please, Enter the first number");
            firstnumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Please, Enter the second number");
            secondnumber = float.Parse(Console.ReadLine());

Console.WriteLine("Please, select your operation:\n + \n - \n * \n /");
Console.Write("your operation is:");
op = char.Parse(Console.ReadLine());


            /*
 {anoher example}:


Console.WriteLine("Please, select your operation:\n + press1 \n - press2 \n * press3 \n / press4");
Console.Write("your operation is:");
int op = 0;
int op = int.parse(Console.ReadLine());


 operations

            switch (op)
{


    case '+':
        result = firstnumber + secondnumber;
        break;


    case '2':
        result = firstnumber - secondnumber;
        break ;


    case '3':
        result = firstnumber * secondnumber;
        break;


    case '4':
        result = firstnumber / secondnumber;
        break;


    default:
        Console.WriteLine("Please, input the right operation");
        break;
}
*/

            //operations

            switch (op)
            {


                case '+':
                    result = firstnumber + secondnumber;
                    break;


                case '-':
                case '_':
                    result = firstnumber - secondnumber;
                    break;


                case '*':
                case 'X':
                case 'x':

                    result = firstnumber * secondnumber;
                    break;


                case '/':
                    result = firstnumber / secondnumber;
                    break;


                default:
                    Console.WriteLine("Please, input the right operation");
                    break;


            }

            if (secondnumber == 0 && op=='/')
            {
                Console.WriteLine("Logic Error");
            }    
            else
            {
                Console.WriteLine("The result={0}", result);
            }

    

}
}
}
