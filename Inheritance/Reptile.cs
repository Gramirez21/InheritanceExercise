using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile: Animal
    {
        public bool HasClaws { get; set; }
        public bool IsItColdBlooded { get; set; }
        public int NumberOfLegs { get; set; }

        public bool DoesItLayEggs { get; set; }

        public void Details()
        {
            Console.WriteLine($"Eyes: {Eyes}");
            Console.WriteLine($"Male Or Female: {MaleOrFemale}");
            Console.WriteLine($"Size {BodySize}");
            Console.WriteLine($"Age {Age}");
            Console.WriteLine($"Does it Have Claws: {HasClaws}");
            Console.WriteLine($"Is it cole blooded?: {IsItColdBlooded}");
            Console.WriteLine($"How many Legs?: {NumberOfLegs}");
            Console.WriteLine($"Does It Lay Eggs: {DoesItLayEggs}");

        }
    }


   
}

