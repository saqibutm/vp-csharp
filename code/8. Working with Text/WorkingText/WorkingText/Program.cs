using System;

namespace WorkingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Saqib Ali ";

            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            Console.WriteLine("Index of ' ': {0} ", index);

            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: {0}", names[0]);
            Console.WriteLine("Last Name: {0}", names[1]);

            var newName = fullName.Replace("Ali", "ALI");
            Console.WriteLine("New Name is: {0}", newName);

            if (String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            var price = 29.95f;
            Console.WriteLine(price.ToString("C"));

        }
    }
}
