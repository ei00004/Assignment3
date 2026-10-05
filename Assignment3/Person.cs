using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        { 
            get { return FirstName + " " + LastName; }
        }
        public int Age { get; set; }
        public bool IsAdult
        {
            get { return Age >= 18; }
        }
    }
}
