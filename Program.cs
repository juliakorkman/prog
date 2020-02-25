using System;

namespace introprog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your given name, friend?"); 
            string givenName = Console.ReadLine();
            Console.WriteLine(givenName); 
            Console.WriteLine("hello" + " "+ givenName + " "+ "oh thats a neat name");

            Console.WriteLine("And now, what's your surname, bruh?");
            string surname = Console.ReadLine();
            Console.WriteLine("nice to meet you" + " " + givenName + " " + surname);
            Console.WriteLine( "oo i wonder what the orgin of that name is");

            Console.WriteLine("what you up these days huh?");
            string Days = Console.ReadLine();
            Console.WriteLine( Days +"?" +" " + "Sucks to be you!");

            Console.WriteLine("goodbye for now, hope to see you soon");


        }
    }
}
