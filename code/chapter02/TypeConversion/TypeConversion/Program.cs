using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit type conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // Explicit type conversion
            byte c = 1;
            int y = (byte) b;
            Console.WriteLine(y);

            // Non-Compatiable type conversion
            string s = "1234";
            int z = Convert.ToInt32(s);
            Console.WriteLine(z);

            string p = "1234";
            byte q = Convert.ToByte(p);
            Console.WriteLine(q);
        }
    }
}
