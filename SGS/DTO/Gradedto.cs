using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    class Gradedto
    {
        private string _studentid;
        private string _studentname;
        private string _courseid;
        private string _section;
        private string _obtained;
        private string _grade;

        public string Studentid { get => _studentid; set => _studentid = value; }
        public string Studentname { get => _studentname; set => _studentname = value; }
        public string Courseid { get => _courseid; set => _courseid = value; }
        public string Section { get => _section; set => _section = value; }
        public string Obtained { get => _obtained; set => _obtained = value; }
        public string Grade { get => _grade; set => _grade = value; }
    }
}
