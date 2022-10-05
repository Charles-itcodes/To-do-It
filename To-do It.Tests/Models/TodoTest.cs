using To_do_It.Data;
using To_do_It.Models;

namespace To_do_It.Tests.Models
{
    public class TodoTest
    {
        [Fact]
        public void TodoClassTest()
        {
            //Arrange
            string description1 = "Finish the assignment!";
            string description2 = "Don't forget to sleep!!!";

            //Act
            ToDo testTodo1 = new ToDo(TodoSequencer.NextTodoId(), description1);
            ToDo testTodo2 = new ToDo(TodoSequencer.NextTodoId(), description2);

            //Assert

            Assert.Equal(description1, testTodo1.Description);
            Assert.Equal(description2, testTodo2.Description);


        }
    }
}
