using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird: Animal
    {
        public Bird()
        {
            BeakSize = "3 Inches";
            WingSpan = 5;
            Height = 3;
            color = "Blue";


        }

        public string BeakSize { get; set; }
        public int WingSpan { get; set;}
        public int Height { get; set; }
        public string color { get; set; }

        public void Details()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Wing Span {10}inches");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Height {Height}inches");
            Console.WriteLine($"BeakSize {BeakSize} cm");
            Console.WriteLine($"Eyes: {Eyes}");
            Console.WriteLine($"Male Or Female: {MaleOrFemale}");
            Console.WriteLine($"Size {BodySize}");
            Console.WriteLine($"Age {Age}");

        }

        
    }
}
