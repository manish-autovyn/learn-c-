using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._Linq
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }
        public int OwnerID { get; set; }

        public Animal(string name = "No Name",
            double weight = 0,
            double height = 0,
            int ownerID = 0,
            int animalID = 0
            )
        {
            Name = name;
            Weight = weight;
            Height = height;
            OwnerID = ownerID;
            AnimalID = animalID;
        }
    }
}
