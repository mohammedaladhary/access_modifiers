using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class BankAccount
    {
        private String accountNumber;
        private float salary;

        // using accessors to get and
        // set the value of accountNumber
        public String accNo
        {

            get { return accountNumber; }

            set { accountNumber = value; }
        }

        // using accessors to get and
        // set the value of salary
        public float accSalary
        {

            get { return salary; }

            set { salary = value; }
        }

    }
}
