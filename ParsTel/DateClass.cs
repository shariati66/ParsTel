using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ParsTel
{
    public class DateClass
    {
        private PersianCalendar pc; 
        protected internal static string SolarDate()
        {
            PersianCalendar persian = new PersianCalendar();
            DateTime date= DateTime.Now;
            int month = persian.GetMonth(date);
            string strMonth = (month < 10 ? ("0" + month):month.ToString());
            int day=persian.GetDayOfMonth(date);
            string strDay = (day<10?("0"+day):day.ToString());
            string solar = string.Format("{0}/{1}/{2}", persian.GetYear(date), strMonth,
                strDay);
            return solar;
        }
        protected internal  int YEAR_SOLAR
        {
            get
            {
                return pc.GetYear(DateTime.Now);
            }
        }
        protected internal int MONTH_SOLAR
        {
            get
            {
                return pc.GetMonth(DateTime.Now);
            }
        }
        protected internal int DAYOFMONTH_SOLAR
        {
            get
            {
                return Int32.Parse(pc.GetDayOfWeek(DateTime.Now).ToString());
            }
        }
    }
}
