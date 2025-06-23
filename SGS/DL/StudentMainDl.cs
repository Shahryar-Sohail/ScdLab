using SGS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DL
{
    class StudentMainDl
    {
        private DBConnection mycon;
        public StudentMainDl()
        {
            mycon = new DBConnection();
        }
        public List<StudentCoursesDto> GetStudentCourses(string id, string name)
        {
            List<StudentCoursesDto> ret = new List<StudentCoursesDto>();
            mycon.Con.Open();
            string query = @"
                            SELECT
                            e.studentid AS Id,
                            mu.name AS Name,
                            c.courseid AS CourseId,
                            c.coursename AS CourseName,
                            t.name AS TeacherName,
                            e.sectionname AS Section
                            FROM Enrollment e
                            INNER JOIN myuser mu ON e.studentid = mu.id
                            INNER JOIN Course c ON e.courseid = c.courseid
                            INNER JOIN Section s ON e.sectionname = s.sectionname AND e.courseid = s.courseid
                            INNER JOIN myuser t ON s.teacherid = t.id
                            WHERE e.studentid = @studentid;";
            SqlCommand cmd = new SqlCommand(query,mycon.Con);
            cmd.Parameters.AddWithValue("@studentid", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StudentCoursesDto dto = new StudentCoursesDto();
                dto.Id = id;
                dto.Name = name;
                dto.CourseId = reader["CourseId"].ToString();
                dto.CourseName = reader["CourseName"].ToString();
                dto.TeacherName = reader["TeacherName"].ToString();
                dto.Section = reader["Section"].ToString();
                ret.Add(dto);
            }
            reader.Close();
            mycon.Con.Close();
            return ret;
        }
        public List<StudentTranscriptDto> GetTranscript(string id)
        {
            List<StudentTranscriptDto> ret = new List<StudentTranscriptDto>();
            mycon.Con.Open();
            string querry = @"SELECT courseid, section, grade FROM Grade WHERE studentid = @id;";
            SqlCommand cmd = new SqlCommand(querry, mycon.Con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StudentTranscriptDto dto = new StudentTranscriptDto();
                dto.Courseid = reader["courseid"].ToString();
                dto.Section = reader["section"].ToString();
                dto.Grade = reader["grade"].ToString();
                ret.Add(dto);
            }
            reader.Close();
            mycon.Con.Close();
            return ret;
        }
        public List<StudentCourseAssessmentDto> GetAssessmetDetails(StudentCoursesDto dto)
        {
            List<StudentCourseAssessmentDto> ret = new List<StudentCourseAssessmentDto>();
            mycon.Con.Open();
            string query = @"
                           SELECT
                            a.title,
                            a.totalmarks,
                            sam.obtainedmarks
                        FROM StudentAssessmentMarks sam
                        INNER JOIN Assessment a ON sam.assessmentid = a.assessmentid
                        WHERE sam.studentid = @studentid
                          AND sam.courseid = @courseid
                          AND a.sectionname = @section;";
            SqlCommand cmd = new SqlCommand(query, mycon.Con);
            cmd.Parameters.AddWithValue("@courseId", dto.CourseId);
            cmd.Parameters.AddWithValue("@studentid", dto.Id);
            cmd.Parameters.AddWithValue("@section", dto.Section);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StudentCourseAssessmentDto dto1 = new StudentCourseAssessmentDto();
                dto1.Assessment = reader["title"].ToString();
                dto1.Totalmarks = reader["totalmarks"].ToString();
                dto1.Obtainedmarks = reader["obtainedmarks"].ToString();
                ret.Add(dto1);
            }
            reader.Close();
            mycon.Con.Close();
            return ret;
        }
    }
}
