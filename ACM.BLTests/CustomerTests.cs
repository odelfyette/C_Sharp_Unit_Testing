using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOffGoalStepsTestGoalIsNull()
        {
            var customer = new Customer();
            string goalSteps = null;
            string actualSteps = "2000";

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOffGoalStepsTestGoalIsNotNumeric()
        {
            var customer = new Customer();
            string goalSteps = "one";
            string actualSteps = "2000";

            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Goal must be numeric", e.Message);
                throw;
            }
        }
    }
}
