using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace University_s_Panel
{
    static class Extentions
    {
        public static void Tarikh(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dateTime);
            int month = pc.GetMonth(dateTime);
            int Day = pc.GetDayOfMonth(dateTime);
            int hour = pc.GetHour(dateTime);
            int min = pc.GetMinute(dateTime);

            Console.Clear();

            Console.WriteLine(  year + "/" + month+"/"+Day +"     " + hour+":"+min);
        }
    }
}
