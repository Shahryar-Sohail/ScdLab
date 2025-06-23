using SGS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DL
{
    class TeacherAssmentDl
    {
        private DBConnection myCon;
        public TeacherAssmentDl()
        {
            myCon = new DBConnection();
        }
        public void AddAssessmentInDB(TeacherAssesmentDto dto,string courseid,string section)
        {
            myCon.Con.Open();
            string querry = @"INSERT INTO dbo.Assessment (title, totalmarks, weightage, courseid, sectionname) " + " VALUES (@title, @totalmarks, @weightage, @courseid, @sectionname);";
            SqlCommand com = new SqlCommand(querry, myCon.Con);
            com.Parameters.AddWithValue("@title", dto.Assessment);
            com.Parameters.AddWithValue("@totalmarks", dto.TotalMarks);
            com.Parameters.AddWithValue("@weightage", dto.Weightage);
            com.Parameters.AddWithValue("@courseid", courseid);
            com.Parameters.AddWithValue("@sectionname", section);

            com.ExecuteNonQuery();
            myCon.Con.Close();
            UpdateStudentAssessmentMarks();


        }
        public void UpdateStudentAssessmentMarks()
        {

            myCon.Con.Open();
            
                try
                {
                    

                    
                    string insertQuery = @"
                    INSERT INTO dbo.StudentAssessmentMarks (studentid, courseid, assessmentid, obtainedmarks)
                    SELECT
                        E.studentid,
                        E.courseid,
                        A.assessmentid,
                        NULL -- Placeholder for obtainedmarks. Adjust if your column is NOT NULL.
                    FROM
                        dbo.Enrollment AS E
                    JOIN
                        dbo.Assessment AS A
                    ON
                        E.courseid = A.courseid AND E.sectionname = A.sectionname
                    LEFT JOIN
                        dbo.StudentAssessmentMarks AS SAM
                    ON
                        E.studentid = SAM.studentid AND A.assessmentid = SAM.assessmentid
                    WHERE
                        SAM.studentid IS NULL; -- Only insert if the pairing doesn't already exist
                ";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, myCon.Con))
                    {
                        cmd.ExecuteNonQuery();
                        myCon.Con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    
                    Console.WriteLine($"Database Error updating StudentAssessmentMarks: {ex.Message}");
                    
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                    throw;
                }
            }
        }
    }


