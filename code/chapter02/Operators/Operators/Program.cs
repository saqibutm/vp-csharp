using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmatic Operators
            var a = 10;
            var b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);


            // Operator Precedence
            var x = 1;
            var y = 2;
            var z = 3;
            Console.WriteLine(x + y * z);
            Console.WriteLine((x + y) * z);

            // Comparsion Operators - Always result in a boolean value
            Console.WriteLine(x > y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(!(x != y));

            //Logical Operators
            Console.WriteLine(z > x && y > x);
            Console.WriteLine(z > x && y == x);



        }
    }
}
