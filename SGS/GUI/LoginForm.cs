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

namespace SGS
{
    public partial class LoginForm: Form
    {
        private LoginDto _loginDto;
        private LoginBl _loginBl;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _loginDto = new LoginDto(txt_name.Text, txt_password.Text);
            _loginBl = new LoginBl();
            this.Hide();
            _loginBl.ValidateLogin(_loginDto).Show(this);
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
