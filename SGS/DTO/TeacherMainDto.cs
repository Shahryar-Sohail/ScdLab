using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    class TeacherMainDto
    {
        private string _courseid;
        private string _courseName;
        private string _section;
        private bool _select;

        public string Courseid { get => _courseid; set => _courseid = value; }
        public string CourseName { get => _courseName; set => _courseName = value; }
        public string Section { get => _section; set => _section = value; }
        public bool Select { get => _select; set => _select = value; }
    }
}
