using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_webApp
{
    public class Student
    {
        public string Name { get; set; }
        public int IDnum { get; set; }
        public int age { get; set; }

        public Student(string name, int IdNum, int age)
        {
            this.Name= name;
            this.IDnum = IdNum;
            this.age = age;
        }
    }
}