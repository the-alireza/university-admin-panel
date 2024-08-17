using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_s_Panel
{
    internal class Masters : Parent
    {
        public int Ms_Id { get; set; }
        public string Ms_Group { get; set;}
        public static int Id { get; set; } = 11110000;

        public Masters( string Ms_Group, string Name,string Family, string City, string PhoneNumber, int Age):base(Name, Family, City, PhoneNumber, Age)
        {
            this.Ms_Group = Ms_Group;

            Id++;
            this.Ms_Id = Id;
        }

        public override void Print()
        {
            PrintParentInfo();
            Console.WriteLine("Master's Id:{0}   Master's Group:{1}", Ms_Id,Ms_Group);
            Console.WriteLine("----------------------------------------");
        }
    }
}
