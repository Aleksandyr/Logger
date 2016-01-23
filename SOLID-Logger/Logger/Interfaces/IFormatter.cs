namespace Logger.Interfaces
{
    using System;
    using Enums;

    public interface IFormatter
    {
        string Format(DateTime date, ReportLevel level, string msg);
    }
}
