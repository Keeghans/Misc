using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    public class GraderAccess
    {
        static public List<Grader> GetGraders()
        {
            List<Grader> list = new List<Grader>();
            //mockup objects
            Grader g1 = new Grader();
            g1.ID = "1";
            g1.FirstName = "Walter";
            g1.LastName = "White";
            g1.HourlyPay = 50.25m;
            g1.Hours = 4;
            list.Add(g1);

            Grader g2 = new Grader();
            g2.ID = "2";
            g2.FirstName = "Gustavo";
            g2.LastName = "Fring";
            g2.HourlyPay = 75;
            g2.Hours = 10;
            list.Add(g2);

            GraduateGrader gg1 = new GraduateGrader();
            gg1.ID = "3";
            gg1.FirstName = "Jesse";
            gg1.LastName = "Pinkman";
            gg1.HourlyPay = 25;
            gg1.Hours = 6;
            gg1.Stipend = 500;
            list.Add(gg1);

            GraduateGrader gg2 = new GraduateGrader();
            gg2.ID = "4";
            gg2.FirstName = "Saul";
            gg2.LastName = "Goodman";
            gg2.HourlyPay = 35;
            gg2.Hours = 9;
            gg2.Stipend = 600;
            list.Add(gg2);

            return list;

        }
    }
}
