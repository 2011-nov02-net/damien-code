using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public class Cat : Mammal
    {
        public override int NumberOfLegs { get; set; }
        public override bool CanSwim { get; set; }
        public override double Height { get; set; }
    }
}
