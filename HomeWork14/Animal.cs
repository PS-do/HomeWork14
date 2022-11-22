using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    public abstract class Animal
    {
        //Разработать абстрактный класс Animal, который описывает животное.Класс содержит следующие элементы:
        //абстрактное свойство - название животного.
        //В классе Animal нужно определить следующие методы:
        //конструктор, устанавливающий значение по умолчанию для названия;
        //абстрактный метод Say(), который выводит звук, который издает животное;
        //неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).
        public string Animal_Name { get; set; }
        public Animal(string name)
        {
            Animal_Name = name;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.Write($"{Animal_Name}");
            Say();
            Console.WriteLine();
        }
    }

    //Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.В классах реализовать следующие элементы:
    //свойство – название животного;
    //метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
    public class Cat : Animal
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Cat(string name)
            : base("Кошка")
        {
            this.Name = name;
        }
        public override void Say()
        {
            Console.Write($" {name} Мяу");
        }
    }

    public class Dog : Animal
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Dog(string name)
            : base("Собака")
        {
            this.Name = name;
        }
        public override void Say()
        {
            Console.Write($" {name} Гав");
        }
    }

}
