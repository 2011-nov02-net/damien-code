using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public interface IAnimal
    {
        int NumberOfLegs { get; set; }
        bool CanSwim { get; set; }
        double Height { get; set; }
    }
}
