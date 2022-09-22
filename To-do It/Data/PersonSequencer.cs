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
        
        return personId = 0;
        
        }
    }
}
