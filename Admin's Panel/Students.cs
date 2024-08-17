using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_s_Panel
{
    internal class Students : Parent
    {
        public int St_Id { get; set; }
        public String Student_Field { get; set; }
        public static int Id { get; set; } = 14030000;





        public Students(String Student_Field, string Name, string Family, string City, string PhoneNumber, int Age) : base(Name, Family, City, PhoneNumber, Age)
        {
            this.Student_Field = Student_Field;

            // if  (Student_Field != null && Student_Field ==  ) { }

            Id++;
            this.St_Id = Id;
        }


        public override void Print()
        {
            PrintParentInfo();
            Console.WriteLine("Student's ID:{0}   student's field:{1}",St_Id,Student_Field);
            Console.WriteLine("----------------------------------------");
        }
    }
}
