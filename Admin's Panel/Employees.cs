using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_s_Panel
{
    internal class Employees : Parent
    {
        public int Emp_Id { get; set; }

        public static int Id { get; set; } = 22220000;





        public Employees(string Name, string Family, string City, string PhoneNumber, int Age) : base(Name, Family, City, PhoneNumber, Age)
        {

            
            Id++;
            Emp_Id = Id;

        }


        public override void Print()
        {
            PrintParentInfo();
            Console.WriteLine("Employee's Id:{0}   ", Emp_Id);
            Console.WriteLine("----------------------------------------");
        }
    }
}
