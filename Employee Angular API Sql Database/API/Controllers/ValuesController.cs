using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using WebAPI.Database;
using System.Configuration;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.Runtime.Caching;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController

    {
        // GET: studentInfo

        [System.Web.Http.HttpGet]
        public List<GetStd> Get()
        {

                GetStd student = new GetStd();
                return student.GetRecord();
            
        }
        public GetStd Get(int ID)
        {
            GetStd student = new GetStd();
            return student.GetRecord(ID);

        }
        [System.Web.Http.HttpDelete]
        public string Delete(int Id)
        {
            try
            {
                GetStd student = new GetStd();
                student.DeleteId(Id);
                return "Deleted Successfully";
            }
            catch
            {
                return "Failed to Delete!";
            }
            

        }
        [System.Web.Http.HttpPost]
        public string Post([FromBody]GetStd emp)
        {
            try
            {
                GetStd student = new GetStd();
                student.AddId(emp);
                return "Added Successfully";
            }
            catch(Exception error)
            {
                return "Failed to Add! "+error;
            }
        }
    }
}
