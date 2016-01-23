namespace Logger.Appenders
{
    using System;
    using System.IO;

    using Enums;
    using Interfaces;

    public class FileAppender : Appender
    {
        private StreamWriter writer;

        public FileAppender(string path, IFormatter formatter) 
            : base(formatter)
        {
            this.Path = path;
            this.writer = new StreamWriter(this.Path, true);
        }

        public string Path { get; set; }

        public override void Append(DateTime date, ReportLevel level, string msg)
        {
            string output = this.Formatter.Format(date, level, msg);
            this.writer.WriteLine(output);
        }

        public void CloseStream()
        {
            this.writer.Close();
        }
    }
}
