using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Жуля");
            dog.ShowInfo();

            Cat cat = new Cat("Мурка");
            cat.ShowInfo();

            Console.ReadKey();
        }
    }
}
