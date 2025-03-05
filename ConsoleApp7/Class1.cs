using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ConsoleApp7
{
    internal class Services
    {
        private string connectionstring;
        public Services(string conection) { 
            connectionstring= conection;
        
        }
        public void insertstudent()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Invertprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name","hafiz");
                    cmd.Parameters.AddWithValue("@age", 2);
                    cmd.ExecuteNonQuery();

                }
                

                
            }
        }
    }
}
