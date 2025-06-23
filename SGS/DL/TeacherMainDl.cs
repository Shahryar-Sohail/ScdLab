using SGS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DL
{
    class TeacherMainDl
    {
        
        private DBConnection myCon;
        public TeacherMainDl()
        {
            myCon = new DBConnection();
        }
        public List<TeacherMainDto> GetSectionsByTeacher(string id)
        {
            List<TeacherMainDto> toRet = new List<TeacherMainDto>();
            myCon.Con.Open();
            string queryString = @"SELECT s.sectionname, s.courseid, c.coursename FROM Section s JOIN Course c ON s.courseid = c.courseid WHERE s.teacherid = @id;";
            SqlCommand com = new SqlCommand(queryString, myCon.Con);
            com.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                TeacherMainDto dto = new TeacherMainDto();
                dto.Courseid = reader["courseid"].ToString();
                dto.CourseName = reader["coursename"].ToString();
                dto.Section = reader["sectionname"].ToString();
                toRet.Add(dto);
            }
            reader.Close();
            myCon.Con.Close();
            return toRet;
        }
        public List<TeacherAssesmentDto> GetTeacherAssesments(TeacherMainDto dto)
        {
            List<TeacherAssesmentDto> toRet = new List<TeacherAssesmentDto>();
            myCon.Con.Open();
            string queryString = @"
    SELECT title, totalmarks, weightage
    FROM Assessment
    WHERE UPPER(courseid) = @courseid AND UPPER(sectionname) = @sectionname;";
            SqlCommand com = new SqlCommand(queryString, myCon.Con);
            com.Parameters.AddWithValue("@courseid", dto.Courseid.Trim().ToUpper());
            com.Parameters.AddWithValue("@sectionname", dto.Section.Trim().ToUpper());
            SqlDataReader reader = com.ExecuteReader();
            
            while (reader.Read())
            {
                TeacherAssesmentDto assesmentDto = new TeacherAssesmentDto();
                assesmentDto.Assessment = reader["title"].ToString();
                assesmentDto.TotalMarks = reader["totalmarks"].ToString();
                assesmentDto.Weightage = reader["weightage"].ToString();
                toRet.Add(assesmentDto);
            }
            reader.Close();
            myCon.Con.Close();
            return toRet;

        }

    }
}
