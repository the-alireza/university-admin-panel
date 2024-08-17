using Admin_s_Panel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace University_s_Panel
{
    internal class Program
    {



        static void Main(string[] args)
        {

            #region تعریف جنریک لیست ها از موجودیها

            List<Students> StList = new List<Students>();
            List<Masters> MsList = new List<Masters>();
            List<Admins> AdmList = new List<Admins>();
            List<Employees> EmpList = new List<Employees>();
            List<Course> CoList = new List<Course>();

            #endregion

            #region  مقداردهی اولیه پیش فرض به موجودی ها و افزودن به لیستها

            Students me = new Students("Computer", "Alireza", "Karimi", "Babol", "09117423724", 25);
            StList.Add(me);

            Masters Ostad1 = new Masters("Computer Engineering", "Ali", "Alavi", "Rasht", "09121112255", 47);
            MsList.Add(Ostad1);

            Admins admin1 = new Admins(3, "me", "123", "Alireza", "Karimi", "tehran", "09117423724", 25);
            AdmList.Add(admin1);

            Employees employee1 = new Employees("sara", "tahmasbi", "tehran", "021-99885566", 29);
            EmpList.Add(employee1);

            Course course1 = new Course("OS", 3, "gholami");
            CoList.Add(course1);

            string adminPanelName = "";

            #endregion



            DateTime d = DateTime.Now;



            #region منوی اولیه

            bool exitMenu = false;

            while (!exitMenu)
            {
                Console.Clear();

                d.Tarikh();

                Methods.ChooseMenu1();

                int natijeVorudi1;
                string vorudiMenu1 = Console.ReadLine();

                if (!int.TryParse(vorudiMenu1, out natijeVorudi1))
                {
                    Methods.JustNumberWarning();
                    continue;
                }

                #endregion

                switch (natijeVorudi1)
                {

                    case 1:

                        #region فرم ورود 



                        #region  وارد کردن نام کاربری و پسوورد


                        string admin_user_enter = "";
                        string admin_pass_enter = "";


                        Admins loggedAdmin = admin1;


                        do
                        {


                            Console.Clear();
                            d.Tarikh();
                            Console.WriteLine();
                            Console.WriteLine("\n\t- You Choosed Sign in Menu.\n\n\t(You can enter # if you want to go back)");


                            Console.Write("\n\t\tEnter your Username: ");
                            admin_user_enter = Console.ReadLine();
                            if (admin_user_enter == "#") break;


                            Console.Write("\n\t\tEnter your password: ");
                            admin_pass_enter = Console.ReadLine();
                            if (admin_pass_enter == "#") break;


                            if (AdmList.Any(a => a.Adm_username == admin_user_enter && a.Adm_password == admin_pass_enter))
                            {


                                loggedAdmin = AdmList.First(a => a.Adm_username == admin_user_enter && a.Adm_password == admin_pass_enter);
                                adminPanelName = loggedAdmin.Name + " " + loggedAdmin.Family;


                                break;


                            }
                            Console.WriteLine("\n\t\t-> oops! not valid!");
                            Thread.Sleep(2000);

                        } while (true);

                        if (admin_user_enter == "#") continue;
                        if (admin_pass_enter == "#") continue;


                        #endregion



                        // ورود به پنل کاربری و مشاهده گزینه ها


                        bool login_form = true;
                        int natijeVorudi2;
                        string vorudiMenu2;

                        do
                        {
                            Console.Clear();
                            d.Tarikh();
                            Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");


                            Console.Write("\n\twelcome {0}", adminPanelName);
                            Console.WriteLine();

                            Methods.ChooseMenu2();

                            vorudiMenu2 = Console.ReadLine();

                            if (vorudiMenu2 == "#") break;

                            if (!int.TryParse(vorudiMenu2, out natijeVorudi2))
                            {
                                Methods.JustNumberWarning();
                                Thread.Sleep(1500);
                                Console.Clear();
                                continue;
                            }

                            switch (natijeVorudi2)
                            {

                                case 1:

                                    #region ثبت نام ادمینهای جدید



                                    if (loggedAdmin.Adm_Access_Level == 3)
                                    {


                                        string ad_reg = "";
                                        int ad_reg_num;

                                        bool new_admin_reg_loop = true;
                                        do
                                        {


                                            Console.Clear();
                                            d.Tarikh();
                                            Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");


                                            Console.Write("\n\twelcome {0}", adminPanelName);
                                            Console.WriteLine();
                                            Console.WriteLine("\n\t(You can enter # if you want to go back)");

                                            Console.Write("\n\t-> How many admins dou you want to register? ");


                                            ad_reg = Console.ReadLine();
                                            if (ad_reg == "#") break;
                                            if (!int.TryParse(ad_reg, out ad_reg_num))
                                            {
                                                Methods.JustNumberWarning();
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                                continue;
                                            }

                                            string adm_reg_name;
                                            string adm_reg_family;
                                            string adm_access;
                                            int adm_access_vorudi = 3;
                                            string adm_reg_city;
                                            string adm_reg_phonenumber;
                                            string adm_reg_age;
                                            int adm_reg_age_vorudi = 0;
                                            string adm_reg_username;
                                            string adm_reg_password;


                                            for (int i = 1; i <= ad_reg_num; i++)
                                            {
                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter admin{0}'s name: ", i);
                                                adm_reg_name = Console.ReadLine();
                                                if (adm_reg_name == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter admin{0}'s family: ", i);
                                                adm_reg_family = Console.ReadLine();
                                                if (adm_reg_family == "#") break;


                                                //

                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t\tEnter admin{0}'s access level: ", i);

                                                    adm_access = Console.ReadLine();
                                                    if (adm_access == "#") break;

                                                    if (!int.TryParse(adm_access, out adm_access_vorudi))
                                                    {
                                                        Methods.JustNumberWarning();
                                                        continue;
                                                    }

                                                    if (adm_access_vorudi < 1 || adm_access_vorudi > 3)
                                                    {
                                                        Console.WriteLine("\n\t\tnot valid! The access level must be 3 or 2 or 1 ");
                                                        Thread.Sleep(2000);
                                                        continue;
                                                    }

                                                    break;

                                                } while (true);

                                                if (adm_access == "#") break;



                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter admin{0}'s city:", i);
                                                adm_reg_city = Console.ReadLine();
                                                if (adm_reg_city == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter admin{0}'s phoneNumber: ", i);
                                                adm_reg_phonenumber = Console.ReadLine();
                                                if (adm_reg_phonenumber == "#") break;


                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t\tEnter admin{0}'s age: ", i);

                                                    adm_reg_age = Console.ReadLine();
                                                    if (adm_reg_age == "#") break;

                                                    if (!int.TryParse(adm_reg_age, out adm_reg_age_vorudi))
                                                    {
                                                        Methods.JustNumberWarning();
                                                        continue;
                                                    }

                                                    break;
                                                } while (true);

                                                if (adm_reg_age == "#") break;

                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t\tEnter admin{0}'s username: ", i);
                                                    adm_reg_username = Console.ReadLine();
                                                    if (adm_reg_username == "#") break;


                                                    if (adm_reg_username.Contains(" "))
                                                    {
                                                        Console.WriteLine("\t\t   username can't include any space!");
                                                        Thread.Sleep(1500);
                                                        continue;
                                                    }

                                                    if (!adm_reg_username.All(char.IsLetterOrDigit))
                                                    {
                                                        Console.WriteLine("\t\t  Your username should only include letters and numbers!");
                                                        Thread.Sleep(1500);
                                                        continue;
                                                    }

                                                    if (AdmList.Any(a => a.Adm_username == adm_reg_username))
                                                    {
                                                        Console.WriteLine("\n\t\t- This username is already taken. Please choose another one.");
                                                        Thread.Sleep(1700);
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                } while (true);
                                                if (adm_reg_username == "#") break;



                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter admin{0}'s password: ", i);
                                                adm_reg_password = Console.ReadLine();
                                                if (adm_reg_password == "#") break;


                                                Admins new_reg_admin = new Admins(adm_access_vorudi, adm_reg_username, adm_reg_password, adm_reg_name, adm_reg_family, adm_reg_city, adm_reg_phonenumber, adm_reg_age_vorudi);
                                                AdmList.Add(new_reg_admin);

                                                Console.WriteLine("\n\t\tRegistration of {0} {1} was successful.", adm_reg_name, adm_reg_family);
                                                Thread.Sleep(2000);
                                                new_admin_reg_loop = false;
                                            }

                                        } while (new_admin_reg_loop);


                                    }
                                    else
                                    {

                                        Methods.DontAccess();

                                    }

                                    #endregion

                                    break;


                                case 2:

                                    #region ثبت نام استادهای جدید

                                    if (loggedAdmin.Adm_Access_Level == 3 || loggedAdmin.Adm_Access_Level == 2)
                                    {



                                        string ms_reg = "";
                                        int ms_reg_num;


                                        bool new_master_reg_loop = true;
                                        do
                                        {


                                            Console.Clear();
                                            d.Tarikh();
                                            Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");


                                            Console.Write("\n\twelcome {0}", adminPanelName);
                                            Console.WriteLine();
                                            Console.WriteLine("\n\t(You can enter # if you want to go back)");

                                            Console.Write("\n\t-> How many new masters dou you want to register? ");


                                            ms_reg = Console.ReadLine();
                                            if (ms_reg == "#") break;
                                            if (!int.TryParse(ms_reg, out ms_reg_num))
                                            {
                                                Methods.JustNumberWarning();
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                                continue;
                                            }

                                            string ms_reg_name;
                                            string ms_reg_family;
                                            string ms_reg_city;
                                            string ms_reg_phonenumber;
                                            string ms_reg_age;
                                            int ms_reg_age_vorudi = 0;

                                            string ms_group = "";
                                            int ms_reg_group_vorudi;
                                            string ms_reg_group = "";

                                            int ms_reg_subgroup_vorudi;
                                            string ms_reg_subgroup = "";



                                            for (int i = 1; i <= ms_reg_num; i++)
                                            {
                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter master{0}'s name: ", i);
                                                ms_reg_name = Console.ReadLine();
                                                if (ms_reg_name == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter master{0}'s family: ", i);
                                                ms_reg_family = Console.ReadLine();
                                                if (ms_reg_family == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter master{0}'s city:", i);
                                                ms_reg_city = Console.ReadLine();
                                                if (ms_reg_city == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter master{0}'s phoneNumber: ", i);
                                                ms_reg_phonenumber = Console.ReadLine();
                                                if (ms_reg_phonenumber == "#") break;


                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t\tEnter master{0}'s age: ", i);

                                                    ms_reg_age = Console.ReadLine();
                                                    if (ms_reg_age == "#") break;

                                                    if (!int.TryParse(ms_reg_age, out ms_reg_age_vorudi))
                                                    {
                                                        Methods.JustNumberWarning();
                                                        continue;
                                                    }

                                                    break;
                                                } while (true);

                                                if (ms_reg_age == "#") break;


                                                #region انتخاب دپارتمان استاد

                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t-> Choose {0} {1}'s Department: ", ms_reg_name, ms_reg_family);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t\t1.Engineering department \n\t\t2.others(nothing yet)");
                                                    Console.Write("\n\t\tYour choice: ");

                                                    ms_reg_group = Console.ReadLine();
                                                    if (ms_reg_group == "#") break;

                                                    if (!int.TryParse(ms_reg_group, out ms_reg_group_vorudi))
                                                    {
                                                        Methods.JustNumberWarning();
                                                        continue;
                                                    }




                                                    switch (ms_reg_group_vorudi)
                                                    {
                                                        case 1:

                                                            #region انتخاب گروه آموزشی اساتید دپارتمان ریاضی

                                                            bool ms_subgroup = true;

                                                            do
                                                            {
                                                                Console.Clear();
                                                                d.Tarikh();
                                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                                Console.WriteLine();
                                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                                Console.Write("\n\t-> Choose {0} {1}'s Group: ", ms_reg_name, ms_reg_family);
                                                                Console.WriteLine();
                                                                Console.WriteLine("\n\t\t1.Computer Engineering\n\t\t2.Power Engineering\n\t\t3.Mechanical Engineering");
                                                                Console.Write("\n\t\tYour choice: ");


                                                                ms_reg_subgroup = Console.ReadLine();
                                                                if (ms_reg_subgroup == "#") break;

                                                                if (!int.TryParse(ms_reg_subgroup, out ms_reg_subgroup_vorudi))
                                                                {
                                                                    Methods.JustNumberWarning();
                                                                    continue;
                                                                }
                                                                switch (ms_reg_subgroup_vorudi)
                                                                {
                                                                    case 1:
                                                                        ms_group = "Computer Engineering";
                                                                        break;

                                                                    case 2:
                                                                        ms_group = "Power Engineering";
                                                                        break;

                                                                    case 3:
                                                                        ms_group = "Mechanical Engineering";
                                                                        break;

                                                                    default:
                                                                        Console.WriteLine("\n\t\tnot valid!");
                                                                        Thread.Sleep(2000);
                                                                        continue;

                                                                }

                                                                break;

                                                            } while (ms_subgroup);


                                                            #endregion

                                                            break;


                                                        case 2:

                                                            #region گروه آموزشی سایر دپارتمان ها

                                                            Console.WriteLine("\n\t\tNothing yet!");
                                                            Thread.Sleep(2000);

                                                            #endregion

                                                            continue;



                                                        default:
                                                            Console.WriteLine("\n\tnot valid!");
                                                            Thread.Sleep(2000);
                                                            continue;
                                                    }

                                                    break;

                                                } while (true);


                                                #endregion

                                                if (ms_reg_name == "#") break;
                                                if (ms_reg_group == "#") break;



                                                Masters new_reg_master = new Masters(ms_group, ms_reg_name, ms_reg_family, ms_reg_city, ms_reg_phonenumber, ms_reg_age_vorudi);
                                                MsList.Add(new_reg_master);

                                                Console.WriteLine("\n\t\tRegistration of {0} {1} was successful.", ms_reg_name, ms_reg_family);
                                                Thread.Sleep(2000);

                                            }
                                            break;
                                        } while (new_master_reg_loop);


                                    }

                                    else if (loggedAdmin.Adm_Access_Level == 1) { Methods.DontAccess(); }



                                    #endregion

                                    break;



                                case 3:

                                    #region ثبت نام دانشجو های جدید

                                    if (loggedAdmin.Adm_Access_Level == 3 || loggedAdmin.Adm_Access_Level == 2)
                                    {



                                        string st_reg = "";
                                        int st_reg_num;


                                        bool new_student_reg_loop = true;
                                        do
                                        {


                                            Console.Clear();
                                            d.Tarikh();
                                            Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");


                                            Console.Write("\n\twelcome {0}", adminPanelName);
                                            Console.WriteLine();
                                            Console.WriteLine("\n\t(You can enter # if you want to go back)");

                                            Console.Write("\n\t-> How many new students dou you want to register? ");


                                            st_reg = Console.ReadLine();
                                            if (st_reg == "#") break;
                                            if (!int.TryParse(st_reg, out st_reg_num))
                                            {
                                                Methods.JustNumberWarning();
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                                continue;
                                            }

                                            string st_reg_name;
                                            string st_reg_family;
                                            string st_reg_city;
                                            string st_reg_phonenumber;
                                            string st_reg_age;
                                            int st_reg_age_vorudi = 0;


                                            int st_reg_faculty_vorudi;
                                            string st_reg_faculty = "";

                                            int st_reg_field_vorudi;
                                            string st_reg_field = "";

                                            string st_field = "";


                                            for (int i = 1; i <= st_reg_num; i++)
                                            {
                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter student{0}'s name: ", i);
                                                st_reg_name = Console.ReadLine();
                                                if (st_reg_name == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter student{0}'s family: ", i);
                                                st_reg_family = Console.ReadLine();
                                                if (st_reg_family == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter student{0}'s city:", i);
                                                st_reg_city = Console.ReadLine();
                                                if (st_reg_city == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter student{0}'s phoneNumber: ", i);
                                                st_reg_phonenumber = Console.ReadLine();
                                                if (st_reg_phonenumber == "#") break;


                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t\tEnter student{0}'s age: ", i);

                                                    st_reg_age = Console.ReadLine();
                                                    if (st_reg_age == "#") break;

                                                    if (!int.TryParse(st_reg_age, out st_reg_age_vorudi))
                                                    {
                                                        Methods.JustNumberWarning();
                                                        continue;
                                                    }

                                                    break;
                                                } while (true);

                                                if (st_reg_age == "#") break;


                                                #region انتخاب دانشکده دانشجو

                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t-> Choose {0} {1}'s Faculty: ", st_reg_name, st_reg_family);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t\t1.Engineering\n\t\t2.others(nothing yet)");
                                                    Console.Write("\n\t\tYour choice: ");

                                                    st_reg_faculty = Console.ReadLine();
                                                    if (st_reg_faculty == "#") break;

                                                    if (!int.TryParse(st_reg_faculty, out st_reg_faculty_vorudi))
                                                    {
                                                        Methods.JustNumberWarning();
                                                        continue;
                                                    }




                                                    switch (st_reg_faculty_vorudi)
                                                    {
                                                        case 1:

                                                            #region انتخاب رشته دانشگاهی دانشجویان مهندسی

                                                            bool student_field_loop = true;

                                                            do
                                                            {
                                                                Console.Clear();
                                                                d.Tarikh();
                                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                                Console.WriteLine();
                                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                                Console.Write("\n\t-> Choose {0} {1}'s Field: ", st_reg_name, st_reg_family);
                                                                Console.WriteLine();
                                                                Console.WriteLine("\n\t\t1.Computer Engineering\n\t\t2.Power Engineering\n\t\t3.Mechanical Engineering");
                                                                Console.Write("\n\t\tYour choice: ");


                                                                st_reg_field = Console.ReadLine();
                                                                if (st_reg_field == "#") break;

                                                                if (!int.TryParse(st_reg_field, out st_reg_field_vorudi))
                                                                {
                                                                    Methods.JustNumberWarning();
                                                                    continue;
                                                                }
                                                                switch (st_reg_field_vorudi)
                                                                {
                                                                    case 1:
                                                                        st_field = "Computer Engineering";
                                                                        break;

                                                                    case 2:
                                                                        st_field = "Power Engineering";
                                                                        break;

                                                                    case 3:
                                                                        st_field = "Mechanical Engineering";
                                                                        break;

                                                                    default:
                                                                        Console.WriteLine("\n\t\tnot valid!");
                                                                        Thread.Sleep(2000);
                                                                        continue;

                                                                }

                                                                break;

                                                            } while (student_field_loop);


                                                            #endregion

                                                            break;


                                                        case 2:

                                                            #region دانشجویان سایر دانشکده ها

                                                            Console.WriteLine("\n\t\tNothing yet!");
                                                            Thread.Sleep(2000);

                                                            #endregion

                                                            continue;



                                                        default:
                                                            Console.WriteLine("\n\tnot valid!");
                                                            Thread.Sleep(2000);
                                                            continue;
                                                    }

                                                    break;

                                                } while (true);


                                                #endregion

                                                if (st_reg_name == "#") break;
                                                if (st_reg_faculty == "#") break;



                                                Students new_reg_student = new Students(st_field, st_reg_name, st_reg_family, st_reg_city, st_reg_phonenumber, st_reg_age_vorudi);
                                                StList.Add(new_reg_student);

                                                Console.WriteLine("\n\t\tRegistration of {0} {1} was successful.", st_reg_name, st_reg_family);
                                                Thread.Sleep(2000);

                                            }
                                            break;

                                        } while (new_student_reg_loop);


                                    }

                                    else if (loggedAdmin.Adm_Access_Level == 1) { Methods.DontAccess(); }

                                    #endregion   


                                    break;


                                case 4:

                                    #region ثبت نام کارکنان جدید

                                    if (loggedAdmin.Adm_Access_Level == 3 || loggedAdmin.Adm_Access_Level == 2)
                                    {


                                        string emp_reg = "";
                                        int emp_reg_num;


                                        bool new_employee_reg_loop = true;
                                        do
                                        {


                                            Console.Clear();
                                            d.Tarikh();
                                            Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");


                                            Console.Write("\n\twelcome {0}", adminPanelName);
                                            Console.WriteLine();
                                            Console.WriteLine("\n\t(You can enter # if you want to go back)");

                                            Console.Write("\n\t-> How many new employees dou you want to register? ");


                                            emp_reg = Console.ReadLine();
                                            if (emp_reg == "#") break;
                                            if (!int.TryParse(emp_reg, out emp_reg_num))
                                            {
                                                Methods.JustNumberWarning();
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                                continue;
                                            }

                                            string emp_reg_name;
                                            string emp_reg_family;
                                            string emp_reg_city;
                                            string emp_reg_phonenumber;
                                            string emp_reg_age;
                                            int emp_reg_age_vorudi = 0;



                                            for (int i = 1; i <= emp_reg_num; i++)
                                            {
                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter employee{0}'s name: ", i);
                                                emp_reg_name = Console.ReadLine();
                                                if (emp_reg_name == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter employee{0}'s family: ", i);
                                                emp_reg_family = Console.ReadLine();
                                                if (emp_reg_family == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter employee{0}'s city:", i);
                                                emp_reg_city = Console.ReadLine();
                                                if (emp_reg_city == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter employee{0}'s phoneNumber: ", i);
                                                emp_reg_phonenumber = Console.ReadLine();
                                                if (emp_reg_phonenumber == "#") break;


                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t\tEnter employee{0}'s age: ", i);

                                                    emp_reg_age = Console.ReadLine();
                                                    if (emp_reg_age == "#") break;

                                                    if (!int.TryParse(emp_reg_age, out emp_reg_age_vorudi))
                                                    {
                                                        Methods.JustNumberWarning();
                                                        continue;
                                                    }

                                                    break;


                                                } while (true);

                                                if (emp_reg_age == "#") break;


                                                Employees new_emp_reg = new Employees(emp_reg_name, emp_reg_family, emp_reg_city, emp_reg_phonenumber, emp_reg_age_vorudi);
                                                EmpList.Add(new_emp_reg);

                                                Console.WriteLine("\n\t\tRegistration of {0} {1} was successful.", emp_reg_name, emp_reg_family);
                                                Thread.Sleep(2000);
                                                new_employee_reg_loop = false;
                                            }

                                        } while (new_employee_reg_loop);


                                    }

                                    else if (loggedAdmin.Adm_Access_Level == 1) { Methods.DontAccess(); }

                                    #endregion

                                    break;




                                case 5:


                                    #region ثبت دروس جدید

                                    if (loggedAdmin.Adm_Access_Level == 3 || loggedAdmin.Adm_Access_Level == 2)
                                    {

                                        string co_reg = "";
                                        int co_reg_num;


                                        bool new_course_reg_loop = true;
                                        do
                                        {


                                            Console.Clear();
                                            d.Tarikh();
                                            Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");


                                            Console.Write("\n\twelcome {0}", adminPanelName);
                                            Console.WriteLine();
                                            Console.WriteLine("\n\t(You can enter # if you want to go back)");

                                            Console.Write("\n\t-> How many courses dou you want to register? ");


                                            co_reg = Console.ReadLine();
                                            if (co_reg == "#") break;
                                            if (!int.TryParse(co_reg, out co_reg_num))
                                            {
                                                Methods.JustNumberWarning();
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                                continue;
                                            }

                                            string co_reg_name = "";
                                            string co_reg_master = "";
                                            string co_reg_unit;
                                            int co_reg_unit_vorudi = 0;



                                            for (int i = 1; i <= co_reg_num; i++)
                                            {
                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter course{0}'s name: ", i);
                                                co_reg_name = Console.ReadLine();
                                                if (co_reg_name == "#") break;


                                                Console.Clear();
                                                d.Tarikh();
                                                Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                Console.Write("\n\twelcome {0}", adminPanelName);
                                                Console.WriteLine();
                                                Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                Console.Write("\n\t\tEnter course{0}'s master: ", i);
                                                co_reg_master = Console.ReadLine();
                                                if (co_reg_master == "#") break;



                                                do
                                                {
                                                    Console.Clear();
                                                    d.Tarikh();
                                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");
                                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                                    Console.WriteLine();
                                                    Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                                                    Console.Write("\n\t\tEnter course{0}'s unit: ", i);

                                                    co_reg_unit = Console.ReadLine();
                                                    if (co_reg_unit == "#") break;

                                                    if (!int.TryParse(co_reg_unit, out co_reg_unit_vorudi))
                                                    {
                                                        Methods.JustNumberWarning();
                                                        continue;
                                                    }

                                                    break;
                                                } while (true);

                                                if (co_reg_unit == "#") break;





                                                Course new_reg_course = new Course(co_reg_name, co_reg_unit_vorudi, co_reg_master);
                                                CoList.Add(new_reg_course);


                                                Console.WriteLine("\n\t\tRegistration of the course {0} was successful.", co_reg_name);
                                                Thread.Sleep(2000);
                                                new_course_reg_loop = false;
                                            }

                                        } while (new_course_reg_loop);


                                    }

                                    else if (loggedAdmin.Adm_Access_Level == 1) { Methods.DontAccess(); }


                                    #endregion


                                    break;


                                case 6:


                                    #region  نمایش لیست ادمین ها

                                    if (loggedAdmin.Adm_Access_Level == 3)
                                    {


                                        Console.Clear();
                                        d.Tarikh();
                                        Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");

                                        Console.Write("\n\twelcome {0}", adminPanelName);
                                        Console.WriteLine();

                                        Console.WriteLine("\n\tList of Admins:\n");

                                        for (int i = 0; i < AdmList.Count; i++)
                                        {

                                            Console.WriteLine("\t\t{0}. {1} {2}    Access Level: {3}    Age: {4}    city: {5}    PhoneNumber: {6}    username: {7}    ID:{8}\n", i + 1, AdmList[i].Name, AdmList[i].Family, AdmList[i].Adm_Access_Level, AdmList[i].Age, AdmList[i].City, AdmList[i].PhoneNumber, AdmList[i].Adm_username, AdmList[i].Adm_Id);

                                        }

                                        Console.Write("\n\t\tEnter any key to go back.");

                                        Console.ReadKey();


                                    }
                                    else if (loggedAdmin.Adm_Access_Level == 2 || loggedAdmin.Adm_Access_Level == 1)
                                    {

                                        Methods.DontAccess();

                                    }

                                    #endregion


                                    break;





                                case 7:


                                    #region نمایش لیست اساتید


                                    Console.Clear();
                                    d.Tarikh();
                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                    Console.WriteLine();

                                    Console.WriteLine("\n\tList of Masters: \n");

                                    for (int i = 0; i < MsList.Count; i++)
                                    {

                                        Console.WriteLine("\t\t{0}. {1} {2}    Age: {3}    group: {4}    city: {5}    PhoneNumber: {6}    ID:{7}\n", i + 1, MsList[i].Name, MsList[i].Family, MsList[i].Age, MsList[i].Ms_Group, MsList[i].City, MsList[i].PhoneNumber, MsList[i].Ms_Id);

                                    }

                                    Console.Write("\n\t\tEnter any key to go back.");

                                    Console.ReadKey();



                                    #endregion


                                    break;


                                case 8:

                                    #region نمایش لیست دانشجویان




                                    Console.Clear();
                                    d.Tarikh();
                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                    Console.WriteLine();

                                    Console.WriteLine("\n\tList of students: \n");

                                    for (int i = 0; i < StList.Count; i++)
                                    {

                                        Console.WriteLine("\t\t{0}. {1} {2}    age: {3}    field: {4}    city: {5}    PhoneNumber: {6}    ID:{7}\n", i + 1, StList[i].Name, StList[i].Family, StList[i].Age, StList[i].Student_Field, StList[i].City, StList[i].PhoneNumber, StList[i].St_Id);

                                    }

                                    Console.Write("\n\t\tEnter any key to go back.");

                                    Console.ReadKey();


                                    #endregion


                                    break;



                                case 9:


                                    #region نمایش لیست کارمندان


                                    Console.Clear();
                                    d.Tarikh();
                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                    Console.WriteLine();

                                    Console.WriteLine("\n\tList of employees: \n");

                                    for (int i = 0; i < EmpList.Count; i++)
                                    {


                                        Console.WriteLine("\t\t{0}. {1} {2}    age: {3}    city: {4}    PhoneNumber: {5}    ID:{6}\n", i + 1, EmpList[i].Name, EmpList[i].Family, EmpList[i].Age, EmpList[i].City, EmpList[i].PhoneNumber, EmpList[i].Emp_Id);


                                    }


                                    Console.Write("\n\t\tEnter any key to go back.");

                                    Console.ReadKey();

                                    #endregion



                                    break;



                                case 10:

                                    #region نمایش لیست دروس


                                    Console.Clear();
                                    d.Tarikh();
                                    Console.WriteLine("\n\tadmins: {0}\t\tmasters: {1}\t\tstudents: {2}\t\tEmployees: {3}\t\tcourses: {4}", AdmList.Count, MsList.Count, StList.Count, EmpList.Count, CoList.Count);
                                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------");

                                    Console.Write("\n\twelcome {0}", adminPanelName);
                                    Console.WriteLine();

                                    Console.WriteLine("\n\tList of courses: \n");

                                    for (int i = 0; i < CoList.Count; i++)
                                    {

                                        Console.WriteLine("\t\t{0}. {1}    course's master: {2}    course's unit: {3}    ID:{4}\n", i + 1, CoList[i].CourseName, CoList[i].CourseMaster, CoList[i].CourseUnit, CoList[i].Course_Id);

                                    }

                                    Console.Write("\n\t\tEnter any key to go back.");

                                    Console.ReadKey();


                                    #endregion

                                    break;


                                default:


                                    break;
                            }





                        } while (login_form);




                        #endregion


                        break;


                    case 2:

                        #region فرم ثبت نام 

                        d.Tarikh();


                        int adm_signup_access = 1;

                        
                        Console.Clear();

                        d.Tarikh();
                        Console.WriteLine();
                        Console.WriteLine("\n\t- You Choosed Sign up Menu.");

                        Console.WriteLine("\n\t(You can enter # every time you want to go back)");
                        Console.Write("\n\t\t- Please Enter Your Name: ");
                        string admin_name = Console.ReadLine();
                        if (admin_name == "#") continue;

                        Console.Clear();
                        d.Tarikh();
                        Console.WriteLine();
                        Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                        Console.Write("\n\t\t- Please Enter Your Family: ");
                        string admin_family = Console.ReadLine();
                        if (admin_family == "#") continue;

                        Console.Clear();
                        d.Tarikh();
                        Console.WriteLine();
                        Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                        Console.Write("\n\t\t- Please Enter Your City: ");
                        string admin_city = Console.ReadLine();
                        if (admin_city == "#") continue;


                        int admin_age_vorudi = 0;
                        string admin_age;
                        do
                        {
                            Console.Clear();
                            d.Tarikh();
                            Console.WriteLine();
                            Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                            Console.Write("\n\t\t- Please Enter Your Age: ");
                            admin_age = Console.ReadLine();
                            if (admin_age == "#") break;


                            if (!int.TryParse(admin_age, out admin_age_vorudi))
                            {
                                Methods.JustNumberWarning();
                            }
                            else
                            {
                                if (admin_age_vorudi < 18)
                                {
                                    Console.WriteLine("\t\t  Your age is under 18!");
                                    Thread.Sleep(1500);
                                    continue;
                                }

                                if (admin_age_vorudi > 80)
                                {
                                    Console.WriteLine("\t\t  You can't be that old!");
                                    Thread.Sleep(1500);
                                    continue;
                                }
                                break;
                            }


                        } while (true);

                        if (admin_age == "#") continue;


                        string admin_phoneNumber;
                        do
                        {
                            Console.Clear();
                            d.Tarikh();
                            Console.WriteLine();
                            Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                            Console.Write("\n\t\t- Please Enter Your PhoneNumber: ");
                            admin_phoneNumber = Console.ReadLine();
                            if (admin_phoneNumber == "#") break;

                            if (admin_phoneNumber.All(char.IsDigit) && admin_phoneNumber.Length == 11)
                            {
                                break;
                            }
                            else
                            {
                                Methods.JustNumberWarning();
                            }
                        } while (true);

                        if (admin_phoneNumber == "#") continue;

                        string admin_username;
                        do
                        {
                            Console.Clear();
                            d.Tarikh();
                            Console.WriteLine();
                            Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                            Console.Write("\n\t\t- Please Enter Your Username: ");
                            admin_username = Console.ReadLine();
                            if (admin_username == "#") break;

                            if (admin_username.Length < 3)
                            {
                                Console.WriteLine("\t\t  Your username must have 3 characters at least!");
                                Thread.Sleep(1500);
                                continue;
                            }

                            if (char.IsDigit(admin_username[0]))
                            {
                                Console.WriteLine("\t\t  Your username can't start with a number!");
                                Thread.Sleep(1500);
                                continue;
                            }

                            if (admin_username.Contains(" "))
                            {
                                Console.WriteLine("\t\t  Your username can't include any space!");
                                Thread.Sleep(1500);
                                continue;
                            }

                            if (!admin_username.All(char.IsLetterOrDigit))
                            {
                                Console.WriteLine("\t\t  Your username should only include letters and numbers!");
                                Thread.Sleep(1500);
                                continue;
                            }

                            if (AdmList.Any(a => a.Adm_username == admin_username))
                            {
                                Console.WriteLine("\n\t\t- This username is already taken. Please choose another one.");
                                Thread.Sleep(1700);
                            }
                            else
                            {
                                break;
                            }
                        } while (true);

                        if (admin_username == "#") continue;


                        string admin_password;
                        do
                        {
                            Console.Clear();
                            d.Tarikh();
                            Console.WriteLine();
                            Console.WriteLine("\n\t(You can enter # every time you want to go back)");

                            Console.Write("\n\t\t- Please Enter Your Password: ");
                            admin_password = Console.ReadLine();

                            if (admin_password == "#") break;

                            if (admin_password.Length < 5)
                            {
                                Console.WriteLine("\t\t  Your password must have 5 characters at least!");
                                Thread.Sleep(1200);

                            }
                            else { break; }

                        } while (true);

                        if (admin_password == "#") continue;


                        Admins admin = new Admins(adm_signup_access, admin_username, admin_password, admin_name, admin_family, admin_city, admin_phoneNumber, admin_age_vorudi);
                        AdmList.Add(admin);

                        Console.WriteLine("\n\t\tYour sign up was successfull. Thank You {0}", admin_name);
                        Thread.Sleep(2500);


                        #endregion

                        break;






                    default:

                        continue;




                }

            }

            Console.ReadKey();
        }
    }
}
