using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    public class GraduateGrader: Grader
    {
        private decimal stipend;

        public decimal Stipend { get => stipend; set => stipend = value; }

        public override decimal GetTotalPay()
        {
            return base.GetTotalPay() + this.Stipend;
        }

     }

}









    
