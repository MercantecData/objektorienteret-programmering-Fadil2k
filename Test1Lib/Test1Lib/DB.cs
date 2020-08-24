using System.Collections.Generic;

namespace Test1Lib

{
    public class DB
    {
        private readonly List<Person> PersonList = new List<Person>();

        public void AddPerson(Person person)
        {
            PersonList.Add(person);
        }

        public void RemovePerson(Person person)
        {
            //PersonList.RemoveAll(x => x.name == name);
        }
    }
}