using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    public class Employee
    {
        private int id;
        private string lastName;
        public decimal salary;
        public int ID { get => id; set => id = value;}
        public string LastName { get => lastName; set => lastName = value; }
        public decimal Salary { get => salary; set => salary = value; }

        virtual public decimal GetIncomTax()
        {
            return (salary * 0.1m);
        }

        public string GetDisplayText()
        {
            return id.ToString() + "\t" + lastName + "\t" + GetIncomTax().ToString("c");
        }

    }
}
