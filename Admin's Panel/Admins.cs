using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_s_Panel
{
    internal class Admins : Parent
    {
        public int Adm_Id { get; set; }


        public int Adm_Access_Level { get; set; }


        public string Adm_username { get; set; }
        public string Adm_password { get; set; }

        public static int Id { get; set; } = 99990000;





        public Admins(int Adm_Access_Level,string Adm_username, string Adm_password, string Name, string Family, string City, string PhoneNumber, int Age) : base(Name, Family, City, PhoneNumber, Age)
        {


            this.Adm_Access_Level = Adm_Access_Level;


            this.Adm_username = Adm_username;
            this.Adm_password = Adm_password;
            
            Id++;
            Adm_Id=Id;
            
        }


        public override void Print()
        {
            PrintParentInfo();
            Console.WriteLine("Admin's Id:{0}   Admin's username:{1}   Admin's password:{2}", Adm_Id, Adm_username, Adm_password);
            Console.WriteLine("----------------------------------------");
        }
    }
}
