using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    class EmployeeAccess
    {
        static public List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();
            //mockup objects
            Employee e1 = new Employee();
            e1.ID = 1;
            e1.LastName = "White";
            e1.Salary = 50.25m;
            list.Add(e1);

            Employee e2 = new Employee();
            e2.ID = 2;
            e2.LastName = "Johnson";
            e2.Salary = 75;
            list.Add(e2);

            Manager m1 = new Manager();
            m1.ID = 3;
            m1.LastName = "Pinkman";
            m1.Salary = 25;
            m1.Bonus = 6;
            list.Add(m1);

            Manager m2 = new Manager();
            m2.ID = 4;
            m2.LastName = "Goodma";
            m2.Salary = 25;
            m2.Bonus = 6;
            list.Add(m2);


            return list;

        }
    
}
}
