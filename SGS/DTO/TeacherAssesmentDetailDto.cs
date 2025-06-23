using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
   public class TeacherAssesmentDetailDto
    {
        private string _courseId;
        private string _section;
        private string _assessmentid;
        private string _totalmarks;
        private string _obtainedmarks;
        private string _studentid;
        private string _studentname;
        private string _title;
        public string CourseId { get => _courseId; set => _courseId = value; }
        public string Section { get => _section; set => _section = value; }
        public string Assessmentid { get => _assessmentid; set => _assessmentid = value; }
        public string Totalmarks { get => _totalmarks; set => _totalmarks = value; }
        public string Obtainedmarks { get => _obtainedmarks; set => _obtainedmarks = value; }
        public string Studentid { get => _studentid; set => _studentid = value; }
        public string Studentname { get => _studentname; set => _studentname = value; }
        public string Title { get => _title; set => _title = value; }
    }
}
