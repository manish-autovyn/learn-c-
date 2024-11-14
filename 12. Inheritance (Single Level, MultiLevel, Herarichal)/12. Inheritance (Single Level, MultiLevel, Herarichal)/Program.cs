using System;

namespace _12._Inheritance__Single_Level__MultiLevel__Herarichal_
{

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Anial is eating.");
        }
    }

    // single inheritance
    // here Dog inherited Animal class
    // hence it is single inheritance
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }


    // multi-level inheritance
    class Mammal : Animal
    {
        public void Run()
        {
            Console.WriteLine("Mammal is running.");
        }
    }
    class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Horse is galloping.");
        }
    }
    // here Horse inherited Mammal and Mammal inherited Animal
    // hence it is multi-level inheritance

    // hierarchical inheritance
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting.");
        }
    }

    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }
    // here Eagle and Penguin both inherited Bird
    // hence it is hierarchical inheritance

    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance
            Console.WriteLine("Inheritance :");

            // single inheritance
            Console.WriteLine("\nsingle inheritance :");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            // multi-level inheritance
            // multi-level inheritance
            Console.WriteLine("\nmulti-level inheritance :");
            Horse horse = new Horse();
            horse.Eat();
            horse.Run();
            horse.Gallop();

            // hierarchical inheritance
            // hierarchical inheritance
            Console.WriteLine("\nhierarchical inheritance :");
            Eagle eagle = new Eagle();
            Penguin penguin = new Penguin();
            eagle.Fly();
            eagle.Hunt();
            penguin.Fly();
            penguin.Swim();
        }
    }
}
