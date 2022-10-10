using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
    public class TodoService
    {
        private static ToDo[] toDoList = new ToDo[0];
        //private static List<ToDo> ToDoList = new List<ToDo>();

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
       /* public void addNewTodo(string description)
        {
            ToDo newTodo = new ToDo(TodoSequencer.NextTodoId(), description);
            ToDoList.Add(newTodo);
            TodoSequencer newTodoseq = new TodoSequencer();
            newTodoseq.
        }*/
       
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

        public ToDo[] removeObjectFromArray(int index)
        {
            //ToDo[] newToDoList = new ToDo[toDoList.Length-1];
            ToDo[] newToDoList = new ToDo[0];

            //int j = 0;
            for (int i = 0; i < toDoList.Length; i++)
            {
                
                if (i != index)
                {
                   // toDoList.Append(toDoList[i]);
                    Array.Resize(ref toDoList, toDoList.Length);
                    newToDoList.CopyTo(toDoList, 0);
                   
                }
                //newToDoList[j] = toDoList[i];
                // j++;
                
            }
            return newToDoList;
        }
        





    }

}
