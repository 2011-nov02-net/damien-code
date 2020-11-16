using System;

namespace AnimalLibrary
{
    public class Person : Mammal
    {
        public override int NumberOfLegs { get; set; }
        public override bool CanSwim { get; set; }
        public override double Height { get; set; }
    }
}
