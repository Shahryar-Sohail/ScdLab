using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.DTO
{
    public class TeacherAssesmentDto
    {
        public bool IsSelected { get; set; } = false; 

        
        public string Assessment { get; set; }

      
        public string TotalMarks { get; set; }

        
        public string Weightage { get; set; }
    }
}
