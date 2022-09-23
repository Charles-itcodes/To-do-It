using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It.Data
{
    internal class TodoSequencer
    {
        private static int ToDo;
        public static int NextToDo()
        {

            return ToDo++;
        }
        public static int Reset()
        {
            ToDo = 0
            return ToDo;

        }
    }
}
/*Create a new class TodoSequencer in Data folder that have the same behaviour as
PersonSequencer but just different names to suit ToDo instead of Person.
a. Unit test TodoSequencer.
b. Commit changes*/