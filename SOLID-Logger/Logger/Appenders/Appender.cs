namespace Logger.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        public Appender(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public IFormatter Formatter { get; set; }

        public abstract void Append(DateTime date, ReportLevel level, string msg);
    }
}
