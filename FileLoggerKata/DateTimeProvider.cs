using System;

namespace FileLoggerKata
{
    public class DateTimeProvider : IDateTimeProvider
    {
        const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss ";
        const string DAY_FORMAT = "yyyy-MM-dd";

        public DateTime Now()
        {
            return DateTime.Now;
        }

        public DateTime Date()
        {
            return Now().Date;
        }

        public string DateTimeFormat()
        {
            return Now().ToString(DATE_TIME_FORMAT);
        }

        public string DayFormat()
        {
            return Date().ToString(DAY_FORMAT);
        }
    }
}