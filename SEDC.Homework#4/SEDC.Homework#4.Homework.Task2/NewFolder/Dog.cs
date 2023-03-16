using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_4.Homework.Task1.Classes
{
    public class Dog
    {
        public Dog()
        {
            Name = Name;
            Race = Race;
            Color = Color;
        }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }


        public void Eat()
        {
            Console.WriteLine($"The dog {Name} is now eating");
        }

        public void Play()
        {
            Console.WriteLine($"The dog {Name} is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"The dog {Name} is now chasing its tail");
        }
    }
}
