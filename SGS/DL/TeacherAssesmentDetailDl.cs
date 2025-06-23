using SGS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DL
{
    class TeacherAssesmentDetailDl
    {
        private DBConnection mycon;
        public TeacherAssesmentDetailDl()
        {
            mycon = new DBConnection();
        }

        public List<TeacherAssesmentDetailDto> GetTeacherAssesmentDetails(string courseId, string section, string title)
        {
            List<TeacherAssesmentDetailDto> toRet = new List<TeacherAssesmentDetailDto>();
            mycon.Con.Open();
            string queryString = @"
            SELECT 
                sma.studentid, 
                mu.name AS studentname, 
                sma.courseid, 
                sma.assessmentid, 
                a.totalmarks, 
                sma.obtainedmarks
            FROM StudentAssessmentMarks sma
            JOIN Assessment a ON sma.assessmentid = a.assessmentid
            JOIN myuser mu ON sma.studentid = mu.id
            WHERE sma.courseid = @courseId 
              AND a.sectionname = @section 
              AND a.title = @title;";
            SqlCommand com = new SqlCommand(queryString, mycon.Con);
            com.Parameters.AddWithValue("@courseId", courseId);
            com.Parameters.AddWithValue("@section", section);
            com.Parameters.AddWithValue("@title", title);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                TeacherAssesmentDetailDto dto = new TeacherAssesmentDetailDto();
                dto.CourseId = reader["courseid"].ToString();
                dto.Assessmentid = reader["assessmentid"].ToString();
                dto.Section = section; // Section is passed as a parameter, so we can set it directly
                dto.Title = title;
                dto.Totalmarks = reader["totalmarks"].ToString();
                dto.Obtainedmarks = reader["obtainedmarks"].ToString();
                dto.Studentid = reader["studentid"].ToString();
                dto.Studentname = reader["studentname"].ToString();
                toRet.Add(dto);
            }
            reader.Close();
            mycon.Con.Close();
            return toRet;
        }
        public void AddObtainedMarksInDB(TeacherAssesmentDetailDto dto)
        {
            mycon.Con.Open();
            string querry = @"UPDATE StudentAssessmentMarks
                SET obtainedmarks = @obtainedmarks
                WHERE studentid = @studentid
                AND courseid = @courseid
                AND assessmentid = @assessmentid;";
            SqlCommand cmd = new SqlCommand(querry, mycon.Con);
            cmd.Parameters.AddWithValue("@studentid", dto.Studentid);
            cmd.Parameters.AddWithValue("@courseid", dto.CourseId);
            cmd.Parameters.AddWithValue("@obtainedmarks", Convert.ToDecimal(dto.Obtainedmarks));
            cmd.Parameters.AddWithValue("@assessmentid", dto.Assessmentid);
            cmd.ExecuteNonQuery();
            mycon.Con.Close();
        }
    }
}
