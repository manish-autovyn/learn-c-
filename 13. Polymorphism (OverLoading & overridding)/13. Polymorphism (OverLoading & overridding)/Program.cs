using System;


class Vehicle
{
    public virtual void Go()
    {

    }
}

class Car : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The car is moving!");
    }
}
class Bicycle : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The bicycle is moving!");
    }
}

class Boat : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The boat is moving!");
    }
}

class OverLoading
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Add(int x, int y, int z)
    {
        return x + y + z;
    }

    public static int Add(params int[] ListNumbers)
    {
        int total = 0;

        // foreach loop 
        foreach (int i in ListNumbers)
        {
            total += i;
        }
        return total;
    }
}

namespace _13._Polymorphism__Method_OverLoading___method_overridding_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // polymorphism
            Console.WriteLine("polymorphism :\n");

            // Polymorphism is a Greek word that means "hav many forms"
            // Objects can be identified by more than one type
            // Ex. A Dog is also Canine, Animal, Organism

            Car car = new();
            Bicycle bicycle = new();
            Boat boat = new();

            Console.WriteLine("method overridding :");

            Vehicle[] vehicles = {car, bicycle, boat};

            foreach (Vehicle v in vehicles)
            {
                v.Go();
            }
            // above code is the example of method overridding

            // Method OverLoading
            Console.WriteLine("\nMethod OverLoading : ");

            int sum1 = OverLoading.Add(2, 5);
            Console.WriteLine("Sum1 : " + sum1);

            int sum2 = OverLoading.Add(3, 6, 7);
            Console.WriteLine("Sum2 : " + sum2);

            int sum3 = OverLoading.Add(3, 6, 7, 4, 8, 9);
            Console.WriteLine("Sum3 : " + sum3);
        }
    }
}