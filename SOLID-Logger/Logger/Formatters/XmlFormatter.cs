namespace Logger.Formatters
{
    using System;
    using System.Text;

    using Enums;
    using Interfaces;

    public class XmlFormatter : IFormatter
    { 
        public string Format(DateTime date, ReportLevel level, string msg)
        {
            var output = new StringBuilder();
            output.AppendLine("<log>");
            output.AppendLine("<message>" + msg + "</message>");
            output.AppendLine("<level>" + level + "</level>");
            output.AppendLine("<date>" + date + "</date>");
            output.AppendLine("</log>");

            return output.ToString();
        }
    }
}
