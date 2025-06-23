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
    public partial class TeacherAssessmentForm: Form
    {
        private List<TeacherAssesmentDto> _assessments;
        private string _courseId;
        private string _section;
        private int _total = 0;
        private TeacherAssesmetnDetailBl _teacherassesmentbl;
        private TeacherAssmentDl _teacherAssmentDl;
        TeacherAssesmentDetailDto dto;
        public TeacherAssessmentForm()
        {
            InitializeComponent();
            _assessments = new List<TeacherAssesmentDto>();
            _teacherAssmentDl = new TeacherAssmentDl();
        }
        public TeacherAssessmentForm(List<TeacherAssesmentDto> dto,string coursid,string section)
        {
            InitializeComponent();
            _assessments = dto;
            _courseId = coursid;
            _section = section;
            _teacherAssmentDl = new TeacherAssmentDl();
            _teacherassesmentbl = new TeacherAssesmetnDetailBl();
            this.dto = new TeacherAssesmentDetailDto();

        }

        private void TeacherAssessmentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _assessments;
            lb_course.Text = _courseId;
            lb_section.Text = _section;
            
            if (dataGridView1 != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    _total += Convert.ToInt32(row.Cells["Weightage"].Value);
                }
            }
            lb_total.Text += _total.ToString();
            //textBox1.Text = _courseId;
            //textBox2.Text = _section;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all fields!!!");
                return;
            }
            if(_total + Convert.ToInt32(textBox3.Text) > 100)
            {
                MessageBox.Show("Total weightage cannot exceed 100.");
                return;
            }
            TeacherAssesmentDto dto  = new TeacherAssesmentDto();
            dto.Assessment = textBox1.Text;
            dto.TotalMarks = textBox2.Text.ToString();
            dto.Weightage = textBox3.Text.ToString();
            dto.IsSelected = false;
            _assessments.Add(dto);
            dataGridView1.DataSource = null; // Clear the existing data source
            dataGridView1.DataSource = _assessments;
            _total += Convert.ToInt32(textBox3.Text);
            lb_total.Text = "Total" + _total.ToString();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            _teacherAssmentDl.AddAssessmentInDB(dto, _courseId, _section);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip new row placeholder
                if (row.IsNewRow) continue;

                bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value);
                if (isChecked)
                {
                    
                    dto.CourseId = _courseId;
                    dto.Section = _section;
                    dto.Totalmarks = row.Cells["TotalMarks"].Value.ToString();
                    dto.Title = row.Cells["Assessment"].Value.ToString();

                }

            }
            this.Hide();
            _teacherassesmentbl.GetDetails(dto).Show(this);
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

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if(_total == 0)
            {
                MessageBox.Show("No assessments available to calculate .");
                return;
            }
            if(_total<100)
            {
                MessageBox.Show("Total weightage cannot be less than 100.");
                return;
                
            }
            TeacherCalculateGrade form = new TeacherCalculateGrade(_courseId, _section);
            this.Hide();
            form.Show(this);
        }

        private void TeacherAssessmentForm_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
