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
    class TeacherAssesmetnDetailBl
    {
        
        private TeacherAssesmentDetailDl _teacherAssementDetailDl;
        public TeacherAssesmetnDetailBl()
        {
            _teacherAssementDetailDl = new TeacherAssesmentDetailDl();
        }

        public Form GetDetails(TeacherAssesmentDetailDto dto)
        {

            return new TeacherAssesmentDetailForm(_teacherAssementDetailDl.GetTeacherAssesmentDetails(dto.CourseId, dto.Section, dto.Title)); 
        }
        public void AddObtainedMarks(TeacherAssesmentDetailDto dto)
        {
            _teacherAssementDetailDl.AddObtainedMarksInDB(dto);
        }
    }
}
