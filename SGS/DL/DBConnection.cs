using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DL
{
    class DBConnection
    {
        private SqlConnection con;
        private string Path;
        private string[] appPath;

        public DBConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\F2022065230\Desktop\New folder\ScdLab\SGS\Database1.mdf"";Integrated Security=True";
            con = new SqlConnection(connectionString);
        }
        public SqlConnection Con { get => con; }
    }
}
