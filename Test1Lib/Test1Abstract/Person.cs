using System;
using System.Collections.Generic;

namespace Test1Abstract
{

    public class Person : IComparable<Person>
    {
        public string name;
        public int age;
        public Gender gender;

        public Person(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public enum Gender
        {
            Male,
            Female,
            Other,
            Undefined
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public int CompareTo(Person X)
        {
            if (this.age < X.age)
            {
                return 1;
            }
            else if (this.age > X.age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}