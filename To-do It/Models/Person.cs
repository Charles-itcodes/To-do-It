using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It.Models
{
     public class Person
    {
        private  int personId;// how to make it readonly?
        private string firstName; //How to prevent saving NULL & Empty.
        private string lastName;

        public Person(int personId, string firstName, string lastName){

            this.PersonId = personId;
            this.FirstName = firstName;
            this.LastName = lastName;

        }//constructor

        public int PersonId { 
        get { return personId; } //getters
         set { personId = value; } } // setters

         public string FirstName{ 

        get { return firstName; } //getters
        set { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Noooo you can not leave me empty i need first name (:");
                }
                else
                {
                    firstName = value;
                }    

              }
        }

        public string LastName{ 

        get { return lastName; } //getters
        set { lastName = value; } }  // setters
       
       
    }
}
