using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_s_Panel
{
    internal class Course
    {
        public string CourseName { get; set; }
        public int CourseUnit { get; set; }

        public string CourseMaster { get; set; }

        public int Course_Id { get; set; }

        public static int Id { get; set; } = 33330000;





        public Course(string CourseName, int CourseUnit, string CourseMaster)
        {
            this.CourseName = CourseName;
            this.CourseUnit = CourseUnit;
            this.CourseMaster = CourseMaster;
          
            Id++;
            Course_Id = Id;
            
        }


        public void Print()
        {
            
            Console.WriteLine("Course's Id:{0}   Course's Name:{1}   Course's unit:{2}   Course's Master:{3}", Course_Id,CourseName,CourseUnit,CourseMaster);
            Console.WriteLine("----------------------------------------");
        }
    }
}
