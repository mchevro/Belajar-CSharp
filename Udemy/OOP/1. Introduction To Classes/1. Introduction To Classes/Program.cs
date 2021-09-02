using System;

namespace _1._Introduction_To_Classes
{
    class Program
    {
        public class Person
        {
            public string name;

            public void Introduction(string to)
            {
                Console.WriteLine("Hi {0}, From {1}", to, name);
            }
        }


        static void Main(string[] args)
        {
            var person = new Person();
            person.name = "Mchevro";
            person.Introduction("Chevro");
        }
    }
}
