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
        private static ToDo[] Todos = new ToDo[0];
        public int Size()
        {
            return Todos.Length;
        }

        public ToDo[] FindAll()
        {
            return Todos;
        }
        /*Create a new class called TodoService inside the Data folder.
        a. TodoItems should have the same functionality as the PeopleService class.
        b. Unit test TodoItems class
        c. Commit changes.*/

        public ToDo addnewTodo(string firstName, string lastName)
        {
            ToDo newTodo = new ToDo(PersonSequencer.NextPersonId(), firstName, lastName);

            Todos.Append(newTodo);

            return newTodo;
        }

        public void Clear()
        {
            Todos = new ToDo[0];
        }
    }
}
