using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okra
{
    public class Context
    {
        public SqlConnection Connection()
        {
            SqlConnection connect = new SqlConnection(@"server = DESKTOP-9J8GTAC\TEW_SQLEXPRESS; database = OkraDb; integrated security = true;");
            connect.Open();
            return connect;
        }
    }
}
