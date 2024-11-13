using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _11._Linq
{
    internal class Program
    {
        static void Basics()
        {
            string[] dogs = { "k 9", "Brian Griffin", "Scooby Doo",
                "Old Yeller", "Rin Tin Tin", "Benji",
                "Charlie B. Barkin", "Lassie", "Snoopy"};

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var dog in dogSpaces)
            {
                Console.WriteLine(dog);
            }
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 1, 4, 5, 15, 16, 17, 18, 19, 20, 30, 35, 40, 44, 42, 28 };

            var GT20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach (var num in GT20)
            {
                Console.Write(num + ", ");
            }
            
            Console.WriteLine($"\nGet Type : {GT20.GetType()}");

            nums[0] = 50;

            var listGT20 = GT20.ToList<int>();
            var arrayGT20 = GT20.ToArray();

            return arrayGT20;
        }

        static void QueryArrayList()
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal{Name = "Heidi",
                Height = .8,
                Weight = 18},

                new Animal
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight = 130
                },

                new Animal
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90
                }
            };

            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach (var animal in smAnimals)
            {
                Console.WriteLine("{0} weights {1}lbs", animal.Name, animal.Weight);
            }

            Console.WriteLine();
        }

        static void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200}
            };

            var animalListEnum = animalList.OfType<Animal>();

            var bigDogs = from dog in animalListEnum
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;

            foreach (var dog in bigDogs)
            {
                Console.WriteLine("A {0} weighs {1}lbs",
                    dog.Name, dog.Weight);
            }

            Console.WriteLine();

        }

        static void QueryAnimalData()
        {
            Animal[] animals = new[]
            {
                new Animal{AnimalID = 1,
                Name = "German Shepherd",
                Height = 25,
                Weight = 77,
                OwnerID = 1},
                new Animal{AnimalID = 2,
                Name = "Chihuahua",
                Height = 7,
                Weight = 4.4,
                OwnerID = 2},
                new Animal{AnimalID = 3,
                Name = "Saint Bernard",
                Height = 30,
                Weight = 200,
                OwnerID = 3},
                new Animal{AnimalID = 4,
                Name = "Pug",
                Height = 12,
                Weight = 16,
                OwnerID = 1},
                new Animal{AnimalID = 5,
                Name = "Beagle",
                Height = 15,
                Weight = 23,
                OwnerID = 2}
            };

            Owner[] owners = new[]
            {
                new Owner{Name = "Doug Parks",
                OwnerID = 1},
                new Owner{Name = "Sally Smith",
                OwnerID = 2},
                new Owner{Name = "Paul Brooks",
                OwnerID = 3}
            };

            Console.WriteLine("\nnameHeight : ");

            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.OwnerID,
                             };

            Array arrNameHeight = nameHeight.ToArray();

            foreach (var animal in arrNameHeight)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.WriteLine("\ninnerjoin : ");

            var innerjoin =
                from animal in animals
                join owner in owners on animal.OwnerID equals owner.OwnerID
                select new
                {
                    OwnerName = owner.Name,
                    AnimalName = animal.Name,
                };

            foreach (var animal in innerjoin)
            {
                Console.WriteLine("{0} owns {1}", animal.OwnerName, animal.AnimalName);
            }

            Console.WriteLine("\ngroupJoin : ");
            var groupJoin = from owner in owners
                            orderby owner.OwnerID
                            join animal in animals
                            on owner.OwnerID equals animal.OwnerID
                            into ownerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animals = from owner2 in ownerGroup
                                          orderby owner2.Name
                                          select owner2
                            };

            int totalAnimals = 0;

            foreach (var animal in innerjoin)
            {
                Console.WriteLine("{0} owns {1}", animal.OwnerName, animal.AnimalName);
            }

            Console.WriteLine();

            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    totalAnimals++;
                    Console.WriteLine("* {0}", animal.Name);
                }
                totalAnimals = 0;
            }

        }

        static void Main(string[] args)
        {
            // Linq
            Console.WriteLine("Linq : \n");

            // basics
            Basics();

            // QueryIntArray
            var arrayGT20 = QueryIntArray();
            foreach (var num in arrayGT20)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            // QueryArrayList
            QueryArrayList();

            //QueryCollection
            QueryCollection();

            // QueryAnimalData
            QueryAnimalData();
        }
    }
}
