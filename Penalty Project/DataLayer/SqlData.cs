using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using PenaltyProject.Models;
using System.Data;

namespace PenaltyProject.DataLayer
{
    public class SqlData : ISqlData
    {
        //To make connection to database

        string conString = "";
        public SqlData(IConfiguration config)
        {
            conString = config.GetConnectionString("Connection");
        }
        
        public List<Country> GetCountries()
        {
            List<Country> countriesList = new List<Country>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT * FROM COUNTRYDATA";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable countriesTable = new DataTable();
            sda.Fill(countriesTable);


            for (int index = 0; index < countriesTable.Rows.Count; index++)
            {
                Country country = new Country
                {
                    countryId = Convert.ToInt32(countriesTable.Rows[index]["CountryID"]),
                    countryName = countriesTable.Rows[index]["CountryName"].ToString(),
                    countrycurrency = countriesTable.Rows[index]["CountryCurrency"].ToString(),
                    penalty = Convert.ToInt32(countriesTable.Rows[index]["PenaltyPerDay"]),
                    tax = Convert.ToInt32(countriesTable.Rows[index]["TaxPerDay"])
                };
                countriesList.Add(country);
            }

            con.Close();
            return countriesList;
        }


    }
}
