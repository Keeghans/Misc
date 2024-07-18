using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class DBConnection
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = null;
            String connectionString = "Data Source=sql.mccoy.txstate.edu;Initial Catalog=cis3325_students;User ID=bobcat3325;Password=Ci$404404";
            conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
