using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace To_do_It.Data
{
    internal class PeopleService
    {
        private static Person[] people = new Person[0];
       
        public int Size()
        {
            return people.Length;
        }

        public Person[] FindAll()
        {
            return people;
        }

        /*Add a method that creates a new Person, adds the newly created object in the array
 and then return the created object. You have to “expand” the Person array. (tip:
 send in parameters needed to create the Person object and use the
 PersonSequencer to give a unique personId)*/
        public Person addNewPerson(string firstName, string lastName)
        {
            Person newPerson = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
           
            people.Append(newPerson);
           
            return new Person;
        }

        public void Clear()
        {
            people = new Person[0];
        }
    }
}
