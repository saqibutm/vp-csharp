using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to convert string to byte");
            }
            
        }
    }
}
