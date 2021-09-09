using System;

namespace CreateStruct
{
    struct Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person(string _firstName, string _lastName, int _age);

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
