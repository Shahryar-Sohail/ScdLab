using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    class LoginDto
    {
        private string _username;
        private string _password;
        private string _roll;
        private string _id;


        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Roll
        {
            get { return _roll; }
            set { _roll = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public LoginDto() { }

        public LoginDto(string text1, string text2)
        {
            this._username = text1;
            this._password = text2;
        }
    }
}
