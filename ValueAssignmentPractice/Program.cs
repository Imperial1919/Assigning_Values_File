using System;
using System.Threading;

namespace ValueAssignmentPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Assign Values:");
            Console.Write("\t a =" + (a = 8));
            Console.Write("\t b =" + (b = 4));

            Console.Write("\n\nAdd and Assign (and other operations): ");
            Console.Write("\t a += b (8 += 4 ) \t a = " + (a += b) + " Now let's try multiplication: \n");
            Console.Write("\t a *= b ( 8 *= 4 ) \t a = " + (a *= b) + "Ok, let's try some division: \n" );
            Console.Write("\t a /= b (8 /= 4) \t a =  " + (a /= b) + "Ok, welp, Multiplication and Divison have now been taken care of. \n" );




            int c;
            int d;


            Console.Write("\t c = " + (c = 20));
            Console.Write("\t d = " + (d = 10));

            Console.Write("\t c += d (20 += 10 ) is equal to:" + (c += d));





           

            
        }
    }
}
