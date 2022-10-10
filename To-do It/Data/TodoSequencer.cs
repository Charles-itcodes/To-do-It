using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
   public class  TodoSequencer
    {
        private static int todoId;

        public static int TodoId
        {
            get { return todoId; }
            set { todoId = value; }
        }

        public static int NextTodoId()
        {
            todoId++;
            return  todoId;
        }
        public static int Reset()
        {
            todoId = 0;
            return todoId;
        }
    }
}
