using GridViewTask2;
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
            if (!IsPostBack)
            {
                // Class named Employee added and getting list of 1000 Empolyees
                List<Employee> dataList = new Employee().GetEmpList();
                Session["data"] = dataList;
                BindGrid();
            }
            

        }

        public void BindGrid()
        {
            //Saving New DataSource in Session as Object type Employee 
            EmpData.DataSource = Session["data"] as List<Employee>;
            EmpData.DataBind();
        }

        protected void EmpData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //When Page Index changes this will update the Session
            
            EmpData.PageIndex = e.NewPageIndex;
            Session["newpage"] = EmpData.PageIndex;
            BindGrid();
        }



        protected void EmpData_RowEditing(object sender, GridViewEditEventArgs e)
        {
            EmpData.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void EmpData_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Deleting Complete Row and Updating Session as Well
            int index = Convert.ToInt32(e.RowIndex);
            List<Employee> newdata = Session["data"] as List<Employee>;
            //Removing Row of Specific/Selected Page and Index
            newdata.RemoveAt(15*Convert.ToInt32(Session["newpage"])+index);
            Session["data"] = newdata;
            BindGrid();
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                List<Employee> update_data = Session["data"] as List<Employee>;
                string a = txtSearch.Text.ToString();
            }
        }

        protected void EmpData_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            TextBox name = EmpData.Rows[e.RowIndex].FindControl("txt_Name") as TextBox;
            TextBox id = EmpData.Rows[e.RowIndex].FindControl("txt_Id") as TextBox;
            List<Employee> changedata = Session["data"] as List<Employee>;

            // Creating New Data
            Employee EmpObj = new Employee();
            EmpObj.Id = id.Text;
            EmpObj.Name = name.Text;
            EmpObj.Role = "Engineer";
            EmpObj.Salary = "100$";

            //Removing Selected Row
            
            changedata.RemoveAt(15 * Convert.ToInt32(Session["newpage"]));

            //Insert New Data on Selected Row
            changedata.Insert(15 * Convert.ToInt32(Session["newpage"]) + index, EmpObj);
            Session["data"] = changedata;
            BindGrid();
        }

        protected void EmpData_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            EmpData.EditIndex = -1;
            BindGrid();
        }
    }
}