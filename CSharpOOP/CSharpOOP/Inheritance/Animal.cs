using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Inheritance
{
    internal class Animal()
    {
        public string? Name { get; set; }

        public void Speak()
        {
            Console.WriteLine("Animal is making a sound.");
        }
    }
}
