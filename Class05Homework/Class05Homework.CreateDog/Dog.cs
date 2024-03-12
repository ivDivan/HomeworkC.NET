using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05Homework.CreateDog
{
    public class Dog
    {
        public string Name { get; set; }   
        public string Breed { get; set; }
        public string Color {  get; set; }
        public string Eat()
        {
            return $"{Name}, the {Color} {Breed}, is now eating.";
        }
        public string Play()
        {
            return $"{Name}, the {Color} {Breed}, is now playing.";
        }
        public string ChaseTail()
        {
            return $"{Name}, the {Color} {Breed}, is now chasing its tail.";
        }
    }
}

