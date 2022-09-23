using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
    internal class PeopleService
    {
        private static Person[] Person = new Person[0];
       
        public int Size()
        {
            return Person.Length;
        }

        public Person[] FindAll()
        {
            return Person;
        }
        /*Create a new class called PeopleService inside the Data folder.
a. Have a private static Person array declared and instantiated as empty
and not null (new Person[0]).
b. Add a method public int Size() that return the length of the array.
c. Add a method public Person[] FindAll() that return the Person array.
d. Add a method public Person FindById(int personId) that return the person that has a
matching personId as the passed in parameter.
e. Add a method that creates a new Person, adds the newly created object in the array
and then return the created object. You have to “expand” the Person array. (tip:
send in parameters needed to create the Person object and use the
PersonSequencer to give a unique personId)
f. Add a method public void Clear() that clears all Person objects from the Person
array.
g. Unit test People class.
h. Commit changes.*/

        public Person FindById(int personId)
        {
            return Person[personId];
        }

        public Person addnewPerson(string firstName, string lastName)
        {
            Person newPerson = new Person(PersonSequencer.NextPersonId(), firstName, lastName);

            Person.Append(newPerson);
           
            return newPerson;
        }

        public void Clear()
        {
            Person = new Person[0];
        }
    }
}
