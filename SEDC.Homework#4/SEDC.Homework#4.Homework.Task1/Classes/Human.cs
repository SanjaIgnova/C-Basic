using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_4.Homework.Task1.Classes
{
    public class Human
    {
        public Human()
        {
            FirstName = FirstName;
            LastName = LastName;
            Age = Age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }    

        public void GetPersonStats()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Age: {Age}");
        }




    }
}
