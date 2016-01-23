namespace Logger.Interfaces
{
    using System;
    using Enums;

    public interface IAppender
    {
        IFormatter Formatter { get; set; }

        void Append(DateTime date, ReportLevel level, string msg);
    }
}
