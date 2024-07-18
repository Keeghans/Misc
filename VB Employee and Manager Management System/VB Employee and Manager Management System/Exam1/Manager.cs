using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    public class Manager: Employee
    {
        private decimal bonus;
    public decimal Bonus { get => bonus; set => bonus = value; }

        public override decimal GetIncomTax()
        {
            
            return (salary + this.Bonus) * .1m;
        }


    }
}
