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
    }
}