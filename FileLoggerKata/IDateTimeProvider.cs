using System;
using System.Collections.Generic;
using System.Text;

namespace FileLoggerKata
{
    public interface IDateTimeProvider
    {
        DateTime Date();
        DateTime Now();
        string DayFormat();
        string DateTimeFormat();
    }
}
