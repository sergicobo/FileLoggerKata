using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileLoggerKata
{
    internal class FileLogger
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public FileLogger(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public void Log(string message)
        {
            StreamWriter sw = new StreamWriter("log.txt");

            sw.WriteLine(_dateTimeProvider.DateTimeFormat() + message);

            sw.Close();
        }
    }
}