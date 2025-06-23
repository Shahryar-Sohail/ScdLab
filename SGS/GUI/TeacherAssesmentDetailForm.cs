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
    public partial class TeacherAssesmentDetailForm: Form
    {
        private List<TeacherAssesmentDetailDto> teacherAssesmentDetailDtos;
        private TeacherAssesmetnDetailBl teacherAssesmetnDetailBl;
        public TeacherAssesmentDetailForm()
        {
            InitializeComponent();
   
        }
        public TeacherAssesmentDetailForm(List<TeacherAssesmentDetailDto> teacherAssesmentDetailDtos)
        {
            InitializeComponent();
            this.teacherAssesmentDetailDtos = teacherAssesmentDetailDtos;
            teacherAssesmetnDetailBl = new TeacherAssesmetnDetailBl();
        }

        private void TeacherAssesmentDetailForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = teacherAssesmentDetailDtos;
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            foreach(var dto in teacherAssesmentDetailDtos)
            {
                dto.Obtainedmarks = dataGridView1.Rows[teacherAssesmentDetailDtos.IndexOf(dto)].Cells["ObtainedMarks"].Value.ToString();
                if(dto.Obtainedmarks== null)
                {
                    MessageBox.Show("Enter all marks!!");
                    return;
                }
                //MessageBox.Show(dto.CourseId + "\n" + dto.Section + "\n" + dto.Title + "\n" +dto.Assessmentid+"\n"+ dto.Studentid + "\n" + dto.Studentname + "\n" + dto.Totalmarks + "\n" + dto.Obtainedmarks);
                teacherAssesmetnDetailBl.AddObtainedMarks(dto);      
               
            }
            MessageBox.Show("Marks added successfully!!");
            
        }

        private void TeacherAssmentDetailForm_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
