using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    public class StudentCourseAssessmentDto
    {
        private string assessment;
        private string totalmarks;
        private string obtainedmarks;

        public string Assessment { get => assessment; set => assessment = value; }
        public string Totalmarks { get => totalmarks; set => totalmarks = value; }
        public string Obtainedmarks { get => obtainedmarks; set => obtainedmarks = value; }
    }
}
