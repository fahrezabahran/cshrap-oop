using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Polymorphism
{
    internal class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }
}
