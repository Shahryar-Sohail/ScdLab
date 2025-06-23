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
    class TeacherMainBl
    {
        private TeacherMainDl _teacherMainDl;
        public TeacherMainBl()
        {
            _teacherMainDl = new TeacherMainDl();
        }
        public Form GetAssesments(TeacherMainDto dto)
        {
            List<TeacherAssesmentDto> ret = _teacherMainDl.GetTeacherAssesments(dto);
            return new TeacherAssessmentForm(ret,dto.Courseid,dto.Section);
        }
    }
}
