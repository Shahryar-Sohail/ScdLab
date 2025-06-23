using SGS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DL
{
    class AdminMainDl
    {
        DBConnection mycon;
        public AdminMainDl()
        {
            mycon = new DBConnection();
        }
       public void AddUser(AdminRegisterUesrDto dto)
        {
            mycon.Con.Open();
            string querry = @"INSERT INTO myuser (id, name, password, roll)
                            VALUES (@id, @name, @password, @roll);";
            SqlCommand cmd = new SqlCommand(querry, mycon.Con);
            cmd.Parameters.AddWithValue("@id", dto.Id);
            cmd.Parameters.AddWithValue("@name", dto.Name);
            cmd.Parameters.AddWithValue("@password", dto.Password);
            cmd.Parameters.AddWithValue("@roll", dto.Role);
            cmd.ExecuteNonQuery();
            mycon.Con.Close();

        }
        public void AddCourse(AdminRegisterCourseDto dto)
        {
            mycon.Con.Open();
            string querry = @"INSERT INTO Course (courseid, coursename, credithrs)
                            VALUES (@courseid, @coursename, @credithrs);";
            SqlCommand cmd = new SqlCommand(querry, mycon.Con);
            cmd.Parameters.AddWithValue("@courseid", dto.Courseid);
            cmd.Parameters.AddWithValue("@coursename", dto.Coursename);
            cmd.Parameters.AddWithValue("@credithrs", dto.Credithrs);
            cmd.ExecuteNonQuery();
        }
    }
}
