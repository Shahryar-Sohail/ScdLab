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
    public partial class AdminRegisterCourse: Form
    {
        private AdminRegisterCourseDto dto;
        private AdminMainDl AdminMainDl;
        public AdminRegisterCourse()
        {
            InitializeComponent();
            dto = new AdminRegisterCourseDto();
            AdminMainDl = new AdminMainDl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto.Courseid = textBox1.Text;
            dto.Coursename = textBox2.Text;
            dto.Credithrs = textBox3.Text;
            AdminMainDl.AddCourse(dto);
            MessageBox.Show("Course Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void AdminRegisterCourse_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
