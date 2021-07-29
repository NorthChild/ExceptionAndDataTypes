using NUnit.Framework;
using System;
using ExceptionsApp;

namespace ExceptionsDataTypeTests
{
    public class GradeTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(-34)]
        [TestCase(-1)]
        [TestCase(-12)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            // the ()=> runs the first part, then compares it to the second part
            Assert.That(()=> Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Allowed range 1-100")); 
        }

        [TestCase(101)]
        [TestCase(150)]
        [TestCase(124134)]
        public void WhenMarkIsGraterThan100_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            // the ()=> runs the first part, then compares it to the second part
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Allowed range 1-100"));
        }







    }
}