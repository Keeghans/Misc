using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    public class Grader
    {
        private string id;
        private string firstName;
        private string lastName;
        private decimal hourlyPay;
        private decimal hours;

        public string ID { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public decimal HourlyPay { get => hourlyPay; set => hourlyPay = value; }
        public decimal Hours { get => hours; set => hours = value; }

        virtual public decimal GetTotalPay()
        {
            return (hourlyPay * hours);
        }

        public string GetDisplayText()
        {
            return id + " " + firstName + " " + lastName + " " + GetTotalPay().ToString("c");
            // Unsure if you want ID, First Name, Last Name, And then Hourly Pay and Hours as well as total pay.
            // If you want Hourly pay, Hours, and total pay uncomment the following code
            //  return id + " " + firstName + " " + lastName + " " + hourlyPay + " " + hours + " " + GetTotalPay().ToString("c");
        }


    }
}