using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void ValidateEmail()
        {
            throw new NotImplementedException();
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            var goalStepCount = new decimal();
            var actualStepCount = new decimal();

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Goal must be entered", "actualSteps");

            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric");
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual steps must be numeric"); 

            return Math.Round((actualStepCount / goalStepCount) * 100, 2);
        }
    }
}
