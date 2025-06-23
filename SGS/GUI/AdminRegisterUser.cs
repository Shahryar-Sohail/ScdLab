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
    public partial class AdminRegisterUser: Form
    {
        private AdminRegisterUesrDto dto;
        private AdminMainDl AdminMainDl;
        public AdminRegisterUser()
        {
            InitializeComponent();
            dto = new AdminRegisterUesrDto();
            AdminMainDl = new AdminMainDl();
        }

        private void AdminRegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto.Id = textBox1.Text;
            dto.Name = textBox2.Text;
            dto.Password = textBox3.Text;
            dto.Role = textBox4.Text;
            AdminMainDl.AddUser(dto);
            MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void AdminRegisterUser_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
