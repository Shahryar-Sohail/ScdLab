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
using static System.Collections.Specialized.BitVector32;

namespace SGS.GUI
{
    public partial class TeacherMainForm : Form
    {
        private TeacherMainDl _teacher;
        private TeacherMainBl _teacherMainBl;
        private TeacherMainDto _dto;
        private string teacherId;
        public TeacherMainForm(string teacherId)
        {
            InitializeComponent();
              this.teacherId = teacherId;
            _teacher = new TeacherMainDl();
            _teacherMainBl = new TeacherMainBl();
            _dto = new TeacherMainDto();
        }
        private void LoadTeacherSections(string teacherId)
        {
            //dataGridView1.Rows.Clear();

            var data =_teacher.GetSectionsByTeacher(teacherId);
            dataGridView1.DataSource = data;


        }
        public void RefreshForm()
        {
            LoadTeacherSections(teacherId);
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            LoadTeacherSections(teacherId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                

                bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value);
                if (isChecked)
                {
                    

                    _dto.Courseid = row.Cells["courseId"].Value.ToString();
                    _dto.CourseName = row.Cells["coursename"].Value.ToString();
                    _dto.Section = row.Cells["section"].Value.ToString();
                }
            }
            this.Hide();
            _teacherMainBl.GetAssesments(_dto).Show(this);
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

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void TeacherMianForm_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}

