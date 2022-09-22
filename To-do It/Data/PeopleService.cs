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
        private static Person[] people = new Person[0];
       
        public int Size()
        {
            return people.Length;
        }

        public Person[] FindAll()
        {
            return people;
        }

        
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
