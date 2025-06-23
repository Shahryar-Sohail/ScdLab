using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    class AdminRegisterUesrDto
    {
        private string _id;
        private string _name;
        private string _password;
        private string _role;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
