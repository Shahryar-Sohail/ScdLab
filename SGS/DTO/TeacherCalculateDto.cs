using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    public class TeacherCalculateDto
    {
        private string _section;
        private string _courseId;
        private string _title;
        private string _studentId;
        private string _studentName;
        private string _totalMarks;
        private string _obtainedMarks;
        private string _weightage;

        public string Section { get => _section; set => _section = value; }
        public string CourseId { get => _courseId; set => _courseId = value; }
        public string StudentId { get => _studentId; set => _studentId = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public string TotalMarks { get => _totalMarks; set => _totalMarks = value; }
        public string ObtainedMarks { get => _obtainedMarks; set => _obtainedMarks = value; }
        public string Weightage { get => _weightage; set => _weightage = value; }
        public string Title { get => _title; set => _title = value; }
    }
}
