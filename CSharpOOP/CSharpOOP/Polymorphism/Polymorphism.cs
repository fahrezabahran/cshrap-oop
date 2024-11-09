using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Polymorphism
{
    internal class Polymorphism
    {
        public static void Run()
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Polimorfisme: metode Speak() pada myDog dan myCat memberikan output berbeda
            myDog.Speak(); // Output: "Dog barks: Woof!"
            myCat.Speak(); // Output: "Cat meows: Meow!"
        }
    }
}

//Override digunakan dalam inheritance (pewarisan), yaitu ketika kelas anak (subclass) ingin mengganti atau menimpa implementasi dari metode yang ada di kelas induknya (superclass).
//Metode yang di-override harus memiliki nama, return type, dan parameter yang sama persis dengan metode di kelas induknya.
//Override membutuhkan kata kunci virtual di metode kelas induk dan override di metode kelas anak.

//Overloading terjadi di dalam satu kelas ketika kita memiliki beberapa metode dengan nama yang sama tetapi parameter yang berbeda (baik dalam jumlah atau tipe parameter).
//Overloading tidak memerlukan pewarisan dan tidak menggunakan kata kunci virtual atau override.
//Tujuan overloading adalah untuk menyediakan beberapa versi metode yang sama untuk mendukung jenis atau jumlah input yang berbeda.