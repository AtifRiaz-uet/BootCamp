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
                List<Employee> dataList = new Employee().GetEmpList();
                Session["data"] = dataList;
                BindGrid();
            }
            

        }

        public void BindGrid()
        {
            EmpData.DataSource = Session["data"] as List<Employee>;
            EmpData.DataBind();
        }

        protected void EmpData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
            EmpData.PageIndex = e.NewPageIndex;
            Session["newpage"] = EmpData.PageIndex;
            BindGrid();
        }



        protected void EmpData_RowEditing(object sender, GridViewEditEventArgs e)
        {
            EmpData.EditIndex = e.NewEditIndex;
            EmpData.DataBind();
        }

        protected void EmpData_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            List<Employee> newdata = Session["data"] as List<Employee>;
            newdata.RemoveAt(15*Convert.ToInt32(Session["newpage"])+index);
            Session["data"] = newdata;
            BindGrid();
        }

        protected void Search_Click(object sender, EventArgs e)
        {

        }

       
    }
}