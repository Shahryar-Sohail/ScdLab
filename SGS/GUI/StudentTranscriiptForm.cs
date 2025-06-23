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
    public partial class StudentTranscriiptForm: Form
    {
        private List<StudentTranscriptDto> studentTranscriptDtos;
        public StudentTranscriiptForm(List<StudentTranscriptDto> dto)
        {
            InitializeComponent();
            studentTranscriptDtos = dto;
        }

        private void StudentTranscriiptForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studentTranscriptDtos;
        }

        private void StdTranscript_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
