using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesting.Data
{
    public static class ReadData
    {


        public int GetNumberOfSearches()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.CraigslistSearches";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(Data.Props.DbConnectionString))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }




        public void ReadDatabase()
        {
            SqlCommand myCommand = new SqlCommand("select * from Requests where Complete = 0", myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())

                Console.WriteLine(myReader["Username"].ToString());
            Console.WriteLine(myReader["Item"].ToString());
            Console.WriteLine(myReader["Amount"].ToString());
            Console.WriteLine(myReader["Complete"].ToString());
        }
    }
}
