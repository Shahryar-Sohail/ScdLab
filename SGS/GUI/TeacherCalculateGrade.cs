using SGS.BL;
using SGS.DL;
using SGS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.GUI
{
    public partial class TeacherCalculateGrade: Form
    {
        private string _courseId;
        private string _section;
        private TeacherCalculateGradeBl _teacherbl;
        private List<TeacherCalculateDto> _teacherCalculateDtos;
        private List<Gradedto> _grade;
        private TeacherCalculateGradeDl _teacherCalculateGradeDl;
        public TeacherCalculateGrade(string courseId, string section)
        {
            InitializeComponent();
            _courseId = courseId;
            _section = section;
            _teacherbl = new TeacherCalculateGradeBl();
            _teacherCalculateDtos = new List<TeacherCalculateDto>();
            _grade = new List<Gradedto>();
            _teacherCalculateGradeDl = new TeacherCalculateGradeDl();
        }

        private void TeacherCalculateGrade_Load(object sender, EventArgs e)
        {
            label1.Text = _courseId;
            label2.Text = _section;
            _teacherCalculateDtos=_teacherbl.GetDetails(_courseId, _section);
            CalculateGrade(_teacherCalculateDtos);
            dataGridView1.DataSource = _grade;

        }
        public void CalculateGrade(List<TeacherCalculateDto> dtos)
        {
            var studentGroups = dtos.GroupBy(d => new { d.StudentId, d.StudentName });

            foreach (var group in studentGroups)
            {
                double totalObtainedWeightage = 0;

                foreach (var dto in group)
                {
                    // Parse values safely
                    if (double.TryParse(dto.ObtainedMarks, out double obtained) &&
                        double.TryParse(dto.TotalMarks, out double total) &&
                        double.TryParse(dto.Weightage, out double weightage)
                        )
                    {
                        totalObtainedWeightage += (obtained / total) * weightage;
                    }
                }
                // Determine grade based on totalObtainedWeightage
                if (totalObtainedWeightage < 50)
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "F",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage
                    });
                }
                else if (totalObtainedWeightage < 55)
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "C-",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage
                    });
                }
                else if (totalObtainedWeightage < 60)
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "C",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage

                    });
                }
                else if (totalObtainedWeightage < 65)
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "C+",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage
                    });
                }
                else if (totalObtainedWeightage < 70)
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "B-",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage
                    });
                }
                else if (totalObtainedWeightage < 75)
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "B",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage
                    });
                }
                else if (totalObtainedWeightage < 80)
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "B+",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage
                    });
                }
                else if (totalObtainedWeightage < 90)
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "A-",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage
                    });
                }
                else
                {
                    _grade.Add(new Gradedto
                    {
                        Studentid = group.Key.StudentId,
                        Studentname = group.Key.StudentName,
                        Courseid = _courseId,
                        Section = _section,
                        Grade = "A",
                        Obtained = totalObtainedWeightage.ToString("F2") // Optional: include obtained weightage
                    });
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grades Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _teacherCalculateGradeDl.InsertGrades(_grade);
            _teacherCalculateGradeDl.DeleteRecods(_courseId, _section);
        }

        private void TeacherCalculateGradeForm_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Close();
        }
    }
}
