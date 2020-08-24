using System;

namespace Test1Abstract
{
    public class Person : IComparable<Person>
    {
        public enum Gender
        {
            Male,
            Female,
            Other,
            Undefined
        }

        public int age;
        public Gender gender;
        public string name;

        public Person(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public int CompareTo(Person X)
        {
            if (age < X.age)
                return 1;
            if (age > X.age)
                return -1;
            return 0;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}