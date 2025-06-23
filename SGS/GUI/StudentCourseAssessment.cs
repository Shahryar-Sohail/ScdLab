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
    public partial class StudentCourseAssessment: Form
    {
        List<StudentCourseAssessmentDto> studentCourseAssessmentDtos;
        public StudentCourseAssessment(List<StudentCourseAssessmentDto> dto)
        {
            InitializeComponent();
            studentCourseAssessmentDtos = dto;
        }

        private void StudentCourseAssessment_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = studentCourseAssessmentDtos;
        }

        private void StdCourseAssessment_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
