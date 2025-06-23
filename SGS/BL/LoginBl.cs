using SGS.DL;
using SGS.DTO;
using SGS.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.BL
{
    class LoginBl
    {
        
        private LoginDL _logindl;
       

        public LoginBl()
        {
            _logindl = new LoginDL();
        }

        public Form ValidateLogin(LoginDto dto)
        {
            // Simulate a login validation
            LoginDto ret = _logindl.VerifyUserFromDB(dto);
            if (ret.Roll == null)
            {
                return new WrongForm();
                
            }
            else if (ret.Roll.Trim().ToLower() == "teacher")
            {
                return new TeacherMainForm(ret.Id.Trim());
            }
            else if (ret.Roll.Trim().ToLower() == "student")
            {
                return new StudentMainForm(ret.Username.Trim(), ret.Id.Trim());
            }
            else if (ret.Roll.Trim().ToLower() == "admin")
            {
                return new AdminMainForm();
            }
            else
            {
                return new WrongForm();
            }


        }
    }
}
