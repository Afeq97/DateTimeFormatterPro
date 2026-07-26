using System;

namespace DateTimeFormatterPro.Services
{
    public class DateFormatterService
    {
        public string Convert(DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }
    }
}