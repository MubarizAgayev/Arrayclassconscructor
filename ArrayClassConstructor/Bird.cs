using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassConstructor
{
    internal class Bird : Animal
    {
        public Bird(string t) :Base(t)
        { 

            Console.WriteLine("Bird");
        }
    }
}
