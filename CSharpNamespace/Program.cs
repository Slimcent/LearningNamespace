using LogMessage;
using System;
using WelcomeMessageNameSpace;

namespace CSharpNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WelcomeMessage message = new WelcomeMessage();
            //message.GreetMessage();
            //Console.ReadLine();

            Notification notification = new Notification();
            notification.Notify();
        }
    }
}

namespace WelcomeMessageNameSpace
{
    class WelcomeMessage
    {
        public void GreetMessage()
        {
            Console.WriteLine("Welcome to C Sharp namespace");
        }
    }
}
