using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewTask2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EmpData.DataSource = new Employee().GetEmpList();
            EmpData.DataBind();
        }

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

                for (int num =1; num < 1001; num++)
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
        protected void PageChanging(object sender, GridViewPageEventArgs e)
        {

            EmpData.PageIndex = e.NewPageIndex;
        }

        protected void EmpData_RowEditing(object sender, GridViewEditEventArgs e)
        {
            EmpData.EditIndex = e.NewEditIndex;
            EmpData.DataBind();
        }

        protected void EmpData_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            EmpData.EditIndex = -1;
            EmpData.DataBind();
        }

        protected void Search_Click(object sender, EventArgs e)
        {

        }
    }
}