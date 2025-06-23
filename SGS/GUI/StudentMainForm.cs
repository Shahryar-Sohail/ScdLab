using SGS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.GUI
{
    public partial class StudentMainForm: Form
    {
        private string name;
        private string id;
        private StudentMainBl StudentMainBl;
        public StudentMainForm(string name,string id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            StudentMainBl = new StudentMainBl();
        }
        

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
               label1.Text = "Welcome " + name;

        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMainBl.GetStudentCourses(id, name).Show(this);

        }

        private void btn_transcript_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMainBl.GetTranscript(id, name).ShowDialog(this);
        }

        private void StudentMainForm_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
