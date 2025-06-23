using SGS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DL
{
    class LoginDL
    {
        private DBConnection myCon;
        public LoginDL()
        {
            myCon = new DBConnection();
        }
        public LoginDto VerifyUserFromDB(LoginDto lg)
        {

            LoginDto toRet = new LoginDto();
            myCon.Con.Open();// exception can come here

            string queryString = "SELECT * FROM myuser WHERE id=@id AND password=@password;";
            SqlCommand com = new SqlCommand(queryString, myCon.Con);
            com.Parameters.AddWithValue("@id", lg.Username);
            com.Parameters.AddWithValue("@password", lg.Password);


            //            string queryString = "SELECT * FROM MyUser WHERE username = '" + lg.Username + "' AND password ='" + lg.Password + "';";  
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                toRet.Username = reader["name"].ToString();
                toRet.Password = reader["password"].ToString();
                toRet.Roll = reader["roll"].ToString();
                toRet.Id = reader["id"].ToString();

            }
            reader.Close();
            myCon.Con.Close();
            return toRet;

        }
    }
}
