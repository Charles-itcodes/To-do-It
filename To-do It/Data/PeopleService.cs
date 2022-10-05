using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
   public class PeopleService
    {
        private static Person[] personList = new Person[0];

        public int Size()
        {
            return personList.Length;
        }
        public Person[] FindAll() 
        { 
            return personList;
        }
        public Person FindById(int personId)
        {
            return personList[personId];
        }
        public Person addPerson(string firstName,string lastName)
        {
            Person newPerson = new Person(firstName, lastName, PersonSequencer.NextPersonId());
           Array.Resize(ref personList, personList.Length+1);
            personList[personList.Length-1] = newPerson;
            return newPerson;
        }
        public void Clear()
        {
            personList = new Person[0];
        }

        public Person[] removeObjectFromArray(int index)
        {
           
            Person[] newPersonList = new Person[0];

           
            for (int i = 0; i < personList.Length; i++)
            {

                if (i != index)
                {
                  
                    Array.Resize(ref personList, personList.Length);
                    newPersonList.CopyTo(personList, 0);

                }
               
            }
            return newPersonList;
        }

    }
}
