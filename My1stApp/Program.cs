using System;
 

namespace My1stApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Is your Name?");
            string Name = Console.ReadLine();

            Console.WriteLine("how age your are?");
            string Age = Console.ReadLine();

            Console.WriteLine("Enter youe phone number:");
            string Contact = Console.ReadLine();

            Console.WriteLine("Enter youe Address:");
            string addr = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("My name is " + Name + Environment.NewLine + "I am " + Age + Environment.NewLine + "My phone is " + Contact + Environment.NewLine + "I am from " + addr + Environment.NewLine + "Thank You for Giving me Your information");
            Console.ReadKey();
        }
    }
}
