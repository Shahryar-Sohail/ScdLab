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
    class StudentMainBl
    {
       
        private StudentMainDl _stdmaindl;
        public StudentMainBl()
        {
            
            _stdmaindl = new StudentMainDl();
        }
        public Form GetStudentCourses(string id,string name)
        {
            return new StudentCorsesForm(_stdmaindl.GetStudentCourses(id,name));
        }
        public Form GetTranscript(string id,string name)
        {
            return new StudentTranscriiptForm(_stdmaindl.GetTranscript(id));
        }
        public Form GetCourseAssessment(StudentCoursesDto dto)
        {
            return new StudentCourseAssessment(_stdmaindl.GetAssessmetDetails(dto));
        }
    }
}
