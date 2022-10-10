using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Data;
using To_do_It.Models;

namespace To_do_It.Tests.Data
{
    public class TodoServiceTest
    {
        [Fact]

        public void CreateNewTodoTest()
        {
            //Arrange
            TodoItem testingTodo = new TodoItem();
            testingTodo.Clear();

            string description1 = "Study";
            string description2 = "Exercise";
            string description3 = "Cook";


            //Act
            ToDo testPerson1 = testingTodo.CreateNewTodo(description1);
            ToDo testPerson2 = testingTodo.CreateNewTodo(description2);
            ToDo testPerson3 = testingTodo.CreateNewTodo(description3);

            //Assert
            Assert.Equal(description1, testPerson1.Description);
            Assert.Equal(description2, testPerson2.Description);
            Assert.Equal(description3, testPerson3.Description);
        }

        [Fact]

        public void FindTodoByIdTest()
        {
            //Arrange
            TodoItem testingTodos = new TodoItem();

            ToDo testTodo1 = testingTodos.CreateNewTodo("Read");
            ToDo testTodo2 = testingTodos.CreateNewTodo("Go swimming");
            ToDo testTodo3 = testingTodos.CreateNewTodo("Finish assignment");
            int checkedTodoId = testTodo3.Id;

            //Act
            ToDo matchedTodo = testingTodos.FindById(checkedTodoId);

            //Assert
            Assert.NotEqual(matchedTodo, testTodo2);
            Assert.NotEqual(matchedTodo, testTodo2);
            Assert.Equal(matchedTodo, testTodo3);

        }


        [Fact]
        public void TodoSizeTest()
        {
            //Assert

            PeopleService testingPeople = new PeopleService();
            testingPeople.CreateNewPerson("Hanna", "Ljung");
            testingPeople.CreateNewPerson("Mona", "Lund");

            int expectedSize = 2;

            //Act
            int actualSize = testingPeople.Size();

            //Assert
            Assert.Equal(expectedSize, actualSize);
        }

        [Fact]
        public void FindAllTodosTest()
        {
            //Arrange            
            PeopleService testingPeople = new PeopleService();
            testingPeople.Clear();

            testingPeople.CreateNewPerson("Fred", "Lindberg");
            testingPeople.CreateNewPerson("Anna", "Molin");
            testingPeople.CreateNewPerson("Jens", "Schmidth");
            int expectedSize = 3;
            //Act
            Person[] foundPersons = testingPeople.FindAll();

            //Assert
            Assert.Equal(expectedSize, foundPersons.Length);
        }

        [Fact]
        public void FindByDoneTest()
        {
            //Arrange
            TodoItem todoTest = new TodoItem();
            todoTest.Clear();

            ToDo todo1 = todoTest.CreateNewTodo("Go running");
            ToDo todo2 = todoTest.CreateNewTodo("Relax");
            ToDo todo3 = todoTest.CreateNewTodo("Finish Assignment");

            todoTest.FindById(todo1.Id).Done = true;
            todoTest.FindById(todo2.Id).Done = false;
            todoTest.FindById(todo3.Id).Done = true;

            //Act
            ToDo[] findDones = todoTest.FindByDoneStatus(true);

            //Assert
            for (int i = 0; i < findDones.Length; i++)
            {
                Assert.True(findDones[i].Done);
            }

            Assert.Contains(todo1, findDones);
            Assert.Contains(todo3, findDones);

        }

        [Fact]
        public void TestFindByAssigneeId()
        {
            //Arrange
            int personId = PersonSequencer.NextPersonId();

            Person assignee = new Person("Fred", "Johnsson", personId);

            TodoItem testTodos = new TodoItem();
            testTodos.Clear();

            ToDo todo1 = testTodos.CreateNewTodo("Go for a run");
            ToDo todo2 = testTodos.CreateNewTodo("Sleep");
            ToDo todo3 = testTodos.CreateNewTodo("Finish the test");
            ToDo todo4 = testTodos.CreateNewTodo("Watch TV");

            todo1.Assignee = assignee;
            todo2.Assignee = assignee;

            //Act
            ToDo[] findAssigneeArray = testTodos.FindByAssignee(personId);

            //Assert
            Assert.Contains(todo1, findAssigneeArray);
            Assert.Contains(todo2, findAssigneeArray);
            Assert.DoesNotContain(todo3, findAssigneeArray);
            Assert.DoesNotContain(todo4, findAssigneeArray);

        }
        [Fact]
        public void FindByAssigneePersonTest()
        {
            //Arrange
            int personId = PersonSequencer.NextPersonId();
            string firstName1 = "Fred";
            string lastName1 = "Johnsson";
            string firstName2 = "Edwin";
            string lastName2 = "NylÃ©n";

            Person assignee1 = new Person(firstName1, lastName1, personId);
            Person expectedAssignee = new Person(firstName2, lastName2, personId);

            TodoItem testTodos = new TodoItem();
            testTodos.Clear();


            ToDo todo1 = testTodos.CreateNewTodo("Go for a run");
            ToDo todo2 = testTodos.CreateNewTodo("Sleep");
            ToDo todo3 = testTodos.CreateNewTodo("Finish the test");

            todo1.Assignee = assignee1;
            todo2.Assignee = expectedAssignee;
            todo3.Assignee = expectedAssignee;

            //Act
            ToDo[] findAssigneeArray = testTodos.FindByAssignee(expectedAssignee);

            //Assert
            Assert.Contains(todo2, findAssigneeArray);
            Assert.Contains(todo3, findAssigneeArray);
            Assert.DoesNotContain(todo1, findAssigneeArray);
        }

        [Fact]
        public void FindUnassignedTodoTest()
        {
            //Arrange
            Person testPerson = new Person("Lotta", "Svensson", PersonSequencer.NextPersonId());
            TodoItem testTodos = new TodoItem();
            ToDo todo1 = testTodos.CreateNewTodo("Have a rest");
            ToDo todo2 = testTodos.CreateNewTodo("Eat");
            ToDo todo3 = testTodos.CreateNewTodo("Work");
            ToDo todo4 = testTodos.CreateNewTodo("Study");
            todo1.Assignee = testPerson;
            todo3.Assignee = testPerson;

            //Act
            ToDo[] unassignedTodos = testTodos.FindUnassignedTodoItems();

            //Assert
            Assert.Contains(todo2, unassignedTodos);
            Assert.Contains(todo4, unassignedTodos);
            Assert.DoesNotContain(todo1, unassignedTodos);
            Assert.DoesNotContain(todo3, unassignedTodos);
        }

        [Fact]
        public void RemoveTodoTest()
        {
            //Arrange
            TodoItem testTodo = new TodoItem();

            ToDo todo1 = testTodo.CreateNewTodo("Eat");
            ToDo todo2 = testTodo.CreateNewTodo("Sleap");
            ToDo todo3 = testTodo.CreateNewTodo("Run");

            //Act
            testTodo.RemoveTodo(todo1.Id);

            //Assert
            Assert.Contains(todo2, testTodo.FindAll());
            Assert.Contains(todo3, testTodo.FindAll());
            Assert.DoesNotContain(todo1, testTodo.FindAll());
        }
    }
}
