using SGS.BL;
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
    public partial class StudentCorsesForm: Form
    {
        private List<StudentCoursesDto> studentCoursesDtos;
        private StudentMainBl _stdmainbl;
        public StudentCorsesForm(List<StudentCoursesDto> dto)
        {
            studentCoursesDtos = dto;
            InitializeComponent();
        }

        private void StudentCorsesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = studentCoursesDtos;
        }

        private void StdCourse_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Select"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        row.Cells["Select"].Value = false;
                    }
                }
                // Toggle the clicked checkbox
                dataGridView1.Rows[e.RowIndex].Cells["Select"].Value = true;
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool IsChecked = Convert.ToBoolean(row.Cells["Select"].Value);
                if (IsChecked)
                {
                    foreach(StudentCoursesDto dto in studentCoursesDtos)
                    {
                        if (dto.CourseId== row.Cells["CourseID"].Value.ToString())
                        {
                            this.Hide();
                            _stdmainbl = new StudentMainBl();
                            _stdmainbl.GetCourseAssessment(dto).Show(this);
                            return;
                        }
                    }
                }
            }
        }
    }
}
