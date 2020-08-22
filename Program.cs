using System;

namespace laba1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Alex", 13);
            Console.WriteLine($"Person1: {person1.Name} {person1.Age} and person2: {person2.Name} {person2.Age}");
        }
    }
    class Person
    {
        public string name;
        public int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Person(string _name, int _age)
        {
            name = _name;
            age = _age;
        }
        public Person()
        {
            name = "Igor";
            age = 14;
        }
        ~Person()
        {
            Console.WriteLine("File delete");
        }
    }
}
