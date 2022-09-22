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

            return ToDo = 0;

        }
    }
}
