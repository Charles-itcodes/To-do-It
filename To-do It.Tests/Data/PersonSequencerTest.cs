﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Data;

namespace To_do_It.Tests.Data
{
    public class PersonSequencerTest
    {
        [Fact]
        public void ResetPersonIdTest()
        {

            //Arrange
            PersonSequencer.Reset();
            int expected = 0;
            int actual;
            actual = PersonSequencer.PersonId;

            //Act
            PersonSequencer.PersonId = 5;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NextPersonIdTest()
        {
            //Arrange
            int expectedId1 = 1;
            int expectedId2 = 2;
            int id1;
            int id2;

            //Act
            id1 = PersonSequencer.NextPersonId();
            id2 = PersonSequencer.NextPersonId();


            //Assert
            Assert.Equal(expectedId1, id1);
            Assert.Equal(expectedId2, id2);

        }
    }
}
