using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    public class StudentTranscriptDto
    {
        private string courseid;
        private string section;
        private string grade;

        public string Courseid { get => courseid; set => courseid = value; }
        public string Section { get => section; set => section = value; }
        public string Grade { get => grade; set => grade = value; }
    }
}
