using System;

namespace _15._Abstraction
{
    //Abstraction
    // abstraction is the process of hiding certain details
    // and showing only essential information to the user.

    //Abstract class:
    // it is a restricted class that cannot be used to create objects
    // (to access it, it must be inherited from another class).
    abstract class Animal
    {
        //Abstract method:
        //  It can only be used in an abstract class, and
        //  it does not have a body.The body is provided
        //  by the derived class (inherited from)
        public abstract void animalSound();

        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Cat : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The cat says: meow meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction :\n");
            Cat cat = new Cat();
            cat.animalSound();
            cat.sleep();
        }
    }
}
