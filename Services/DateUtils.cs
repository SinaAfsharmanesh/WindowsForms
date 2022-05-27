using System.Globalization;
using System.Text;

namespace WindowsForms.Services
{
    internal static class DateUtils
    {
        public static DateTime Jalali_Miladi(string date)
        {
            var parts = date.Split('/');
            return new DateTime(Convert.ToInt32(parts[0]),
                                Convert.ToInt32(parts[1]),
                                Convert.ToInt32(parts[2]),
                                new PersianCalendar());
        }

        public static string JalaliMonth(DateTime date)
        {
            switch (new PersianCalendar().GetDayOfMonth(date))
            {
                case 1:
                    return "farvardin";

                case 2:
                    return "ordibehesht";

                case 3:
                    return "khordad";

                case 4:
                    return "tir";

                case 5:
                    return "mordad";

                case 6:
                    return "shahrivar";

                case 7:
                    return "mehr";

                case 8:
                    return "aban";

                case 9:
                    return "azar";

                case 10:
                    return "day";

                case 11:
                    return "bahman";

                case 12:
                    return "esfand";

                default:
                    break;
            }

            return "?";
        }

        public static string JalaliSeason(DateTime date)
        {
            return (new PersianCalendar().GetDayOfMonth(date)) switch
            {
                1 => "bahar",
                2 => "bahar",
                3 => "bahar",
                4 => "tabestan",
                5 => "tabestan",
                6 => "tabestan",
                7 => "paiiz",
                8 => "paiiz",
                9 => "paiiz",
                10 => "zemestan",
                11 => "zemestan",
                12 => "zemestan",
                _ => throw new NotImplementedException(),
            };
        }

        /// <summary>
        /// Convert miladi to persian calendar
        /// </summary>
        /// <param name="date"></param>
        /// <returns>string of date</returns>
        public static string Miladi_Jalali(this DateTime date)
        {
            var pc = new PersianCalendar();
            int year = pc.GetYear(date);
            int month = pc.GetMonth(date);
            int day = pc.GetDayOfMonth(date);

            StringBuilder? result = new();
            _ = result.Append(year)
                      .Append('/')
                      .Append(month)
                      .Append('/')
                      .Append(day);

            return result.ToString();
        }
    }
}