using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Full Name:");
            string fullName=Console.ReadLine();
            Console.WriteLine("Welcome  - {0}!",fullName);
            Console.ReadKey();
        }      
    }
}
