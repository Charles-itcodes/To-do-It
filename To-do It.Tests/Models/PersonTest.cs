using System;
using To_do_It.Data;
using To_do_It.Models;

namespace To_do_It.Tests.Models
{
    public class PersonTest
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void PreventFirstNameFromSavingNullOrEmpty(string firstName)
        {
            //Arrange
            Person person = new Person("Charles","Rudahusha", PersonSequencer.NextPersonId());

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => person.FirstName = firstName);
            //Assert
            Assert.Contains("FirstName", result.Message);

        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void PreventLastNameFromSavingNullOrEmpty(string lastName)
        {
            //Arrange
            Person person = new Person("Maria", "Svensson", PersonSequencer.NextPersonId());

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => person.LastName = lastName);
            //Assert
            Assert.Contains("LastName", result.Message);

        }

        [Fact]
        public void PersonClassTest()
        {
            // Arrange
            string firstName1 = "Åsa";
            string lastName1 = "Jonsson";
            string firstName2 = "Simon";
            string lastName2 = "Elbrink";
            string firstName3 = "Abdulkadir";
            string lastName3 = "Mohamud";


            // Act
            Person testPerson1 = new Person(firstName1, lastName1, PersonSequencer.NextPersonId());
            Person testPerson2 = new Person(firstName2, lastName2, PersonSequencer.NextPersonId());
            Person testPerson3 = new Person(firstName3, lastName3, PersonSequencer.NextPersonId());

            // Assert        
            Assert.Equal(firstName1, testPerson1.FirstName);
            Assert.Equal(lastName1, testPerson1.LastName);
            Assert.Equal(firstName2, testPerson2.FirstName);
            Assert.Equal(lastName2, testPerson2.LastName);
            Assert.Equal(firstName3, testPerson3.FirstName);
            Assert.Equal(lastName3, testPerson3.LastName);


        }
    }
}