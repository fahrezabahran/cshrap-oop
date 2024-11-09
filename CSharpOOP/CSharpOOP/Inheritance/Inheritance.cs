using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Inheritance
{
    internal class Inheritance
    {
        public static void Run()
        {
            Cat cat = new();
            Dog dog = new();

            // akses Name dari class Animal
            cat.Name = "Foo";
            dog.Name = "Bar";

            // akses Speak dari class Animal
            cat.Speak();
            dog.Speak();

            cat.Meow();
            dog.Bark();
        }
    }
}
