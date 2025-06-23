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
    public partial class AdminMainForm: Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMain_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminRegisterUser().Show(this);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminRegisterCourse().Show(this);
            
        }
    }
}
