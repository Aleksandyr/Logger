namespace Logger.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(IFormatter formatter) 
            : base(formatter)
        {
        }

        public override void Append(DateTime date, ReportLevel level, string msg)
        {
            var output = this.Formatter.Format(date, level, msg);

            Console.WriteLine(output);
        }
    }
}
