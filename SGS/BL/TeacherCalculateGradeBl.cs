using SGS.DL;
using SGS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.BL
{
    class TeacherCalculateGradeBl
    {
        private TeacherCalculateGradeDl _teacherCalculateGradeDl;
        private List<TeacherCalculateDto> _teacherCalculateDtos;
        public TeacherCalculateGradeBl()
        {
            _teacherCalculateGradeDl = new TeacherCalculateGradeDl();
        }
        public List<TeacherCalculateDto> GetDetails(string courseId, string section)
        {
            // This method will call the data layer to get the details
            // For now, we can just return a placeholder or throw an exception
            return _teacherCalculateDtos = _teacherCalculateGradeDl.GetDetails(courseId, section);


        }
    }
}
