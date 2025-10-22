using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace первое
{
    internal class Person
    {
        public string name;
        public int age;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("ошибка");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 && value > 120)
                {
                    Console.WriteLine("ошибка");
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void SayHello()
        {
            Console.WriteLine($"привет, я {name}, мне {age} лет");
        }

        static void Main(string[] args)
        {
            Person person = new Person("Матвей", 17);
            person.SayHello();
        }
    }
}

