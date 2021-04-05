using System;

namespace StingBool
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to convert string to byte");
            }
        }
    }
}
