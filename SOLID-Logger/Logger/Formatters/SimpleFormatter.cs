namespace Logger.Formatters
{
    using System;
    using Enums;
    using Interfaces;

    public class SimpleFormatter : IFormatter
    {
        public string Format(DateTime date, ReportLevel level, string msg)
        {
            var output = string.Format("{0} - {1} - {2}", date, level, msg);

            return output;
        }
    }
}
