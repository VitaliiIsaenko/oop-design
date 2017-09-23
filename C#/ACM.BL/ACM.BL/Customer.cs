using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public static int InstanceCount { get; set; }

        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
    }
}
