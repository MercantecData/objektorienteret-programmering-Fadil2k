using System;
using System.Collections.Generic;

namespace Test1Lib
{

    public class Person
    {
        public Person(string name, int age, string job, string company)
        {
            this.name = name;
            this.age = age;
            Job = new Job(job, company);
        }

        public string name { get; set; }
        public int age { get; set; }
        public Job Job { get; set; }
        
    }
}
