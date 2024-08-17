using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using University_s_Panel;

namespace Admin_s_Panel
{
    internal class Methods
    {
        DateTime d = DateTime.Now;

        public static void ChooseMenu1()
        {

            Console.WriteLine("\n\tWelcome\n\n\t- Please Enter the Menu's Number: ");
            Console.WriteLine("\n\t\t1.Sign in\n\t\t2.Sign up");
            Console.Write("\n\t\t- Your Choice: ");



        }

        public static void JustNumberWarning()
        {
            Console.WriteLine("\n\t\tWarning!!\n\t\tPlease Enter just correct numbers");
            Thread.Sleep(1500);

        }

        public static void ChooseMenu2()
        {

            Console.WriteLine("\n\t-> Please Enter the Menu's Number: ");
            Console.WriteLine("\n\t\t1.Register new admins\n\t\t2.Register new masters\n\t\t3.Register new students\n\t\t4.Register new employees\n\t\t5.Register new courses\n\t\t6.View the list of admins\n\t\t7.View the list of masters\n\t\t8.View the list of students\n\t\t9.View the list of employees\n\t\t10.View the list of courses\n\t\t#.Exit");
            Console.Write("\n\t\t- Your Choice: ");



        }


        public static void DontAccess()
        {

            Console.WriteLine("\n\t\tSorry you don't have the access!");
            Thread.Sleep(2500);
        }

    }
}
