using Student_webApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace Student_webApp
{
    public class StudentList
    {
        public static List<Student> StudentData = new List<Student>();

        public static void StudentListGen()
        {
            Student student1 = new Student("Garry", 1, 21);
            StudentData.Add(student1);
            Student student2 = new Student("Gaty", 2, 22);
            StudentData.Add(student2);
            Student student3 = new Student("Gauss", 3, 23);
            StudentData.Add(student3);
            Student student4 = new Student("John", 4, 24);
            StudentData.Add(student4);
            Student student5 = new Student("Alex", 5, 25);
            StudentData.Add(student5);
            Student student6 = new Student("Anthony", 6, 26);
            StudentData.Add(student6);
            Student student7 = new Student("Usaid", 7, 27);
            StudentData.Add(student7);
            Student student8 = new Student("shazil", 8, 28);
            StudentData.Add(student8);
            Student student9 = new Student("Stephen", 9, 29);
            StudentData.Add(student9);
            Student student10 = new Student("Saira", 10, 30);
            StudentData.Add(student10);
            Student student11 = new Student("katherine", 11, 31);
            StudentData.Add(student11);
            Student student12 = new Student("Holly", 12, 32);
            StudentData.Add(student12);
            Student student13 = new Student("Jessica", 13, 33);
            StudentData.Add(student13);
            Student student14 = new Student("Jenma", 14, 34);
            StudentData.Add(student14);
            Student student15 = new Student("arslan", 15, 35);
            StudentData.Add(student15);
            Student student16 = new Student("iqbal", 16, 36);
            StudentData.Add(student16);
            Student student17 = new Student("atif", 17, 37);
            StudentData.Add(student17);
            Student student18 = new Student("umair", 18, 38);
            StudentData.Add(student18);
            Student student19 = new Student("awais", 19, 39);
            StudentData.Add(student19);
            Student student20 = new Student("Mugheez", 20, 40);
            StudentData.Add(student20);

        }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> List = new List<Student>();
            StudentList.StudentListGen();

            dropList.DataSource = StudentList.StudentData;
            dropList.DataTextField = "Name";
            dropList.DataValueField = "IDnum";
            dropList.DataBind();
        }
        [WebMethod]
        public static Student GetStudentInfo(string rollNo)
        {
            foreach (var student in StudentList.StudentData)
            {
                if (student.IDnum == Convert.ToInt32(rollNo))
                {
                    return student;
                }
            }
            return new Student("arslan", 15, 25);
        }
}   }