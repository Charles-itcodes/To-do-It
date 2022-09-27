using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
    public class TodoService
    {
        private static ToDo[] toDoList = new ToDo[0];

        public int Size()
        {
            return toDoList.Length;
        }
        public ToDo[] FindAll()
        {
            return toDoList;
        }
        public ToDo FindById(int todoId)
        {
            return toDoList[todoId];
        }
        public ToDo addToDo(string Description)
        {
            ToDo newToDo = new ToDo(TodoSequencer.NextTodoId(), Description);

            newToDo.Description = Description;
            return newToDo;
        }
        public void Clear()
        {
            toDoList = new ToDo[0];
        }
        public  ToDo[] FindByDoneStatus(bool doneStatus)
        {
            ToDo[] toDoList = new ToDo[0];

           for (int i = 0; i < toDoList.Length; i++)
            {
                if (toDoList[i].Done== doneStatus)
                {
                    toDoList.Append(toDoList[i]);
                }
            }
            return (ToDo[])toDoList.ToArray();
        }
        public ToDo[] FindByAssignee(int personId)
        {
            ToDo[] toDoList = new ToDo[0];

            for (int i = 0; i < toDoList.Length; i++)
            {
                if (toDoList[i].Assignee.PersonId == personId)
                {
                    toDoList.Append(toDoList[i]);
                }
            }
            return (ToDo[])toDoList.ToArray();
        }


        public ToDo[] FindByAssignee(Person assignee)
        {
            ToDo[] toDoList = new ToDo[0];

            for (int i = 0; i < toDoList.Length; i++)
            {
                if (toDoList[i].Assignee == assignee)
                {
                    toDoList.Append(toDoList[i]);
                }
            }
            return (ToDo[])toDoList.ToArray();
        }
        public ToDo[] FindUnassignedTodoItems()
        {
            ToDo[] toDoList = new ToDo[0];

            for (int i = 0; i < toDoList.Length; i++)
            {
                if (toDoList[i].Assignee == null)
                {
                    toDoList.Append(toDoList[i]);
                }
            }
            return (ToDo[])toDoList.ToArray();
        }

        public void removeObjectFromArray() { }
    }

}
