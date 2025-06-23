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
    public partial class WrongForm: Form
    {
        public WrongForm()
        {
            InitializeComponent();
        }

        private void WrongForm_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
