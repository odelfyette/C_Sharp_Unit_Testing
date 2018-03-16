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
    }
}
