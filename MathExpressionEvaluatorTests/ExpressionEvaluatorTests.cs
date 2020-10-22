using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathExpressionEvaluator.Tests
{
    [TestClass()]
    public class ExpressionEvaluatorTests
    {
        // Test evaluate method with pass scenario with valid expression
        [TestMethod()]
        public void EvaluateTestPassCase()
        {
            //Arrange
            ExpressionEvaluator testObj = new ExpressionEvaluator("1+2+3");

            //Act
            int result = testObj.Evaluate();

            //Assert
            Assert.AreEqual(6, result);
        }


        //Test evaluate method with exception scenario with Invalid Expression
        [TestMethod()]
        [ExpectedException(typeof(System.FormatException))]
        public void EvaluateTestFailCase()
        {
            //Arrange 
            ExpressionEvaluator testObj = new ExpressionEvaluator("1++3");

            //Act
            int result = testObj.Evaluate();

        }
    }
}