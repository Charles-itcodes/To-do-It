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
        private static toDo[] TodoItems = new toDo[0];
        public int Size()
        {
            return TodoItems.Length;
        }

        public toDo[] FindAll()
        {
            return TodoItems;
        }


        public toDo addNewTodo(string firstName, string lastName)
        {
            toDo newTodo = new toDo(PersonSequencer.NextPersonId(), firstName, lastName);

            TodoItems.Append(newTodo);

            return new toDo;
        }

        public void Clear()
        {
            TodoItems = new toDo[0];
        }
    }
}
