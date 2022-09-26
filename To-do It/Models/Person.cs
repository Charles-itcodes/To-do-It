using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It.Models
{
     public class Person
    {
        private readonly  int personId;
        private string firstName; 
        private string lastName;
        private object v;

        public Person(int personId, string firstName, string lastName){

            this.personId = personId;
            FirstName = firstName;
            LastName = lastName;

        }//constructor

        public int PersonId { 
        get { return personId; } //getters
         } 

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
        set { if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last Name can not be null or empty");
                }
                else
                {
                    lastName = value;
                }

                } }  // setters
       
       
    }
}
