using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    class AdminRegisterCourseDto
    {
        private string _courseid;
        private string _coursename;
        private string _credithrs;

        public string Courseid { get => _courseid; set => _courseid = value; }
        public string Coursename { get => _coursename; set => _coursename = value; }
        public string Credithrs { get => _credithrs; set => _credithrs = value; }
    }
}
