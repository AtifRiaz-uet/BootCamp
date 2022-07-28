using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridViewTask2
{
        public class Employee
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }
            public string Salary { get; set; }
            public List<Employee> GetEmpList()

            {

                List<Employee> EmpList = new List<Employee>();
                //Employee EmpObj = new Employee();

                for (int num = 1; num < 1001; num++)
                {
                    Employee EmpObj = new Employee();
                    EmpObj.Id = "10" + Convert.ToString(num);
                    EmpObj.Name = "Name" + Convert.ToString(num);
                    EmpObj.Role = "Engineer";
                    EmpObj.Salary = "100$";
                    EmpList.Add(EmpObj);
                }

                return EmpList;

            }

        }
}