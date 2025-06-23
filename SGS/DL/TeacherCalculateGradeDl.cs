using SGS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DL
{
    class TeacherCalculateGradeDl
    {
        DBConnection mycon;
        public TeacherCalculateGradeDl()
        {
            mycon = new DBConnection();
        }
        public List<TeacherCalculateDto> GetDetails(string couseid, string section)
        {
            mycon.Con.Open();
            string querry = @"SELECT
                            sam.studentid,
                            mu.name AS studentname,
                            a.title,
                            a.totalmarks,
                            sam.obtainedmarks,
                            a.weightage
                            FROM StudentAssessmentMarks sam
                            INNER JOIN myuser mu ON sam.studentid = mu.id
                            INNER JOIN Assessment a ON sam.assessmentid = a.assessmentid
                            WHERE sam.courseid = @courseid
                            AND a.sectionname = @section";
            SqlCommand com = new SqlCommand(querry, mycon.Con);
            com.Parameters.AddWithValue("@courseid", couseid);
            com.Parameters.AddWithValue("@section", section);
            SqlDataReader reader = com.ExecuteReader();
            List<TeacherCalculateDto> list = new List<TeacherCalculateDto>();
            while (reader.Read())
            {
                TeacherCalculateDto dto = new TeacherCalculateDto();
                dto.StudentId = reader["studentid"].ToString();
                dto.StudentName = reader["studentname"].ToString();
                dto.CourseId = couseid;
                dto.Section = section;
                dto.Title = reader["title"].ToString();
                dto.TotalMarks = reader["totalmarks"].ToString();
                dto.ObtainedMarks = reader["obtainedmarks"].ToString();
                dto.Weightage = reader["weightage"].ToString();
                list.Add(dto);
            }
            reader.Close();
            mycon.Con.Close();
            return list;
        }
        public void InsertGrades(List<Gradedto> grades)
        {
            mycon.Con.Open();
            foreach (var grade in grades)
            {
                string query = @"INSERT INTO Grade (studentid, studentname, courseid, section, obtained, grade)
                                VALUES (@studentid, @studentname, @courseid, @section, @obtained, @grade)";
                SqlCommand cmd = new SqlCommand(query, mycon.Con);
                cmd.Parameters.AddWithValue("@studentid", grade.Studentid);
                cmd.Parameters.AddWithValue("@studentname", grade.Studentname);
                cmd.Parameters.AddWithValue("@courseid", grade.Courseid);
                cmd.Parameters.AddWithValue("@section", grade.Section);
                cmd.Parameters.AddWithValue("@obtained", grade.Obtained);
                cmd.Parameters.AddWithValue("@grade", grade.Grade);
                cmd.ExecuteNonQuery();
                
            }
            mycon.Con.Close();
        }
        public void DeleteRecods(string courseid,string section)
        {
            mycon.Con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mycon.Con;
            cmd.CommandText = @"DELETE FROM StudentAssessmentMarks
                        WHERE courseid = @courseid
                          AND studentid IN (SELECT studentid FROM Enrollment WHERE courseid = @courseid AND sectionname = @section);
                        DELETE FROM Assessment
                        WHERE courseid = @courseid
                          AND sectionname = @section;
                        DELETE FROM Enrollment
                        WHERE courseid = @courseid
                          AND sectionname = @section;
                        DELETE FROM Section
                        WHERE courseid = @courseid
                          AND sectionname = @section;";
            cmd.Parameters.AddWithValue("@courseid", courseid);
            cmd.Parameters.AddWithValue("@section", section);
            cmd.ExecuteNonQuery();
        }
    }
}
