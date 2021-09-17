using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WPF_Restaurant.Model
{
    class DbConnection
    {
        static string connString = "Data Source=DESKTOP-910JD2V;Initial Catalog=WPF;User ID=sa;Password=1234";
        public SqlConnection conn = new SqlConnection(connString);




    }
}
