using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    public class StudentCoursesDto
    {
        private string _id;
        private string _name;
        private string _courseId;
        private string _courseName;
        private string _teacherName;
        private string _section;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string CourseId { get => _courseId; set => _courseId = value; }
        public string CourseName { get => _courseName; set => _courseName = value; }
        public string TeacherName { get => _teacherName; set => _teacherName = value; }
        public string Section { get => _section; set => _section = value; }
    }
}
