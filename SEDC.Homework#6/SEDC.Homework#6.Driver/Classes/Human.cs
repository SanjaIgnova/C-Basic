using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_6.Driver.Classes
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        void GetPersonDetails()
        {
            Console.WriteLine($"{FirstName} {LastName} has {Age} years.");
        }
    }
}
