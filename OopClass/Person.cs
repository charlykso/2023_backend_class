using System;

namespace OopClass
{
    public class Person
    {
        private string name;
        public string Name{
            get { return name; }
            set { name = value; }
        }
        public int Age { get; set; }
    }
}