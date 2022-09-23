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
        private static Person[] person = new Person[0];

        public int Size()
        {
            return person.Length;
        }
        public Person[] FindAll() 
        { 
            return person;
        }
        public Person FindById(int personId)
        {
            return person[personId];
        }
        public Person addPerson(string firstName,string lastNmae)
        {
            return person;
        }

    }
}
