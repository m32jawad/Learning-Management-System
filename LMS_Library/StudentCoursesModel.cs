using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Library
{
    public class StudentCoursesModel
    {
        public int CCID;
        public CourseModel Course = new CourseModel();
        public ClassModel Class = new ClassModel();
        public TeacherModel teacher = new TeacherModel();
    }
}
