using System;
namespace ClassesFundamentals
{
    public class Person
    {
        public String FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
