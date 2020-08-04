using System;
using System.Collections.Generic;

namespace Test1Lib

{
    public class DB
    {

        List<Person> PersonList = new List<Person>();

        public void AddPerson(string name, int age, string job, string company)
        {
            PersonList.Add(new Person(name, age, job, company));

        }
        public void RemovePerson(string name)
        {
            PersonList.RemoveAll(x => x.name == name);
        }
    } 
}
