using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridView
{
    public class Student
    {
        public string Roll_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Student> GetStdList()

        {

            List<Student> StdLst = new List<Student>();
            Student StdObj = new Student();
            StdObj.Roll_No = "01";
            StdObj.Name = "UMAR";
            StdObj.Address = "Lahore";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "02";
            StdObj.Name = "NIKHIL VATS";
            StdObj.Address = "Karachi";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "03";
            StdObj.Name = "KUMAR GAURAV";
            StdObj.Address = "Islamabad";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "04";
            StdObj.Name = "RAM PRAKSSH";
            StdObj.Address = "Delhi";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "05";
            StdObj.Name = "VISHAL";
            StdObj.Address = "Mumbai";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "06";
            StdObj.Name = "Anaya";
            StdObj.Address = "Peshawar";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "07";
            StdObj.Name = "Talha";
            StdObj.Address = "Lahore";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "08";
            StdObj.Name = "Junaid";
            StdObj.Address = "Pindi";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "09";
            StdObj.Name = "Daim";
            StdObj.Address = "Lahore";
            StdLst.Add(StdObj);

            StdObj = new Student();
            StdObj.Roll_No = "10";
            StdObj.Name = "KALM";
            StdObj.Address = "Naran";
            StdLst.Add(StdObj);

            return StdLst;

        }
    }
}