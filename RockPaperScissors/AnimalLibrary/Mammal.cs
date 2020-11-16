using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public abstract class Mammal
    {
        public abstract int NumberOfLegs { get; set; }
        public abstract bool CanSwim { get; set; }
        public abstract double Height { get; set; }

        public bool LaysEggs => false;
    }
}
