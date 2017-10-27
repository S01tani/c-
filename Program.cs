using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramControlStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //the if-else-if statement
            // Determine smallest single-digit factor.
            int num;
            for(num=2;num<100;num++)
            {
                if((num % 2) ==0)
                    Console.WriteLine("factor of {0} is 2",num);
                else if ((num % 3)==0)
                    Console.WriteLine("factor of {0} is 3",num);
                else if ((num % 5)==0)
                    Console.WriteLine("factor of {0} is 5",num);
                else if ((num % 7)==0)
                    Console.WriteLine("factor of {0} is 7",num);
                else
                    Console.WriteLine(num + "is not divisible by 2,3,5 or 7.");
            }
            // the switch statement
            //we use it before in menu example.
            // the nested switch is cool
            char node;
            for(node='A';node < 'L' ; node++)

                switch (node)
                {
                    case 'A':
                        Console.WriteLine("A has three children");
                        string S= Console.ReadLine();
                        switch (S)
                        {
                            case "D":
                                Console.WriteLine("first child");
                                break;
                            case "E":
                                Console.WriteLine("second child");
                                break;
                            case "F":
                                Console.WriteLine("third child");
                                break;
                        }
                        break;
                    case 'B':
                        Console.WriteLine("B selected");
                        break;
                    default:
                        Console.WriteLine("character is not found");
                        break;
                }
            //for statement is already used in other program
            //do while
            // Display the digits of an integer in reverse order.
            int num1;
            int nextdigit;
            num1 = 198;
            Console.WriteLine("number: "+ num1);
            Console.WriteLine("number in reverse order: ");
            do
            {
                nextdigit = num1 % 10;
                Console.WriteLine(nextdigit);
                num1 = num1 / 10;

            }
            while (num1 > 0);
            Console.WriteLine();
            // goto statement
            int i = 0, j = 0, k = 0;
            for (i = 0; i < 10; i++)
            { for (j = 0; j < 10; j++)
                { for (k = 0; k < 10; k++)
                    { Console.WriteLine("i, j, k: " + i + " " + j + " " + k);
                        if (k == 3) goto stop;
                    }
                }
            }
        stop: Console.WriteLine("Stopped! i, j, k: " + i + ", " + j + " " + k);
        }
    }
}
