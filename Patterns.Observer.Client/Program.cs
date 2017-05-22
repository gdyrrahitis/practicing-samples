using System;
using System.Collections.Generic;

namespace Patterns.Observer.Client
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var subscriber1 = new Subscriber();
            var subscriber2 = new Subscriber();

            var publisher = new Publisher(new List<ISubscriber>
            {
                subscriber1, subscriber2
            });

            var message = "Hello world";
            publisher.Message = message;

            publisher.Message = "Hello universe!";

            Console.ReadLine();
        }
    }
}
