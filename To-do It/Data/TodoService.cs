using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
    internal class TodoService
    {
        private static ToDo[] TodoItems = new ToDo[0];
        public int Size()
        {
            return TodoItems.Length;
        }

        public ToDo[] FindAll()
        {
            return TodoItems;
        }


        public ToDo addNewTodo(string firstName, string lastName)
        {
            ToDo newTodo = new ToDo(PersonSequencer.NextPersonId(), firstName, lastName);

            TodoItems.Append(newTodo);

            return new ToDo;
        }

        public void Clear()
        {
            TodoItems = new ToDo[0];
        }
    }
}
