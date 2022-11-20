using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNamespace
{
    public class Registration
    {
        public void Display()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();

            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
