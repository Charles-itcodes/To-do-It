using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It.Data
{
    internal class PersonSequencer
    {
        private static int personId;
        public static int NextPersonId(){
 
            return personId++;
        }
        public static int Reset() {
            personId = 0;
            return personId;


        }
    }
}
/*Create a new class PersonSequencer in Data folder.
a. In PersonSequencer creates a private static int variable called personId.
b. Add a public static method called NextPersonId that increment and return the next
personId value.
c. Add a public static method called Reset() that sets the personId variable to 0.
d. No Properties.
e. Unit test PersonSequencer.
f. Commit changes.*/
