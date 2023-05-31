using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nexus_connect.Services.TimeServices
{
    public class TimeConverter
    {
        public static string TimeStampToDateWithTimeZone(long timestamp)
        {
            try
            {
                TimeZoneInfo timeZoneInfo = TimeZoneInfo.Local;
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp);
                TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneInfo.Id);
                DateTime convertedDateTime = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone);
                return convertedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}