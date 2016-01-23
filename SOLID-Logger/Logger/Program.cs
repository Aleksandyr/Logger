namespace Logger
{
    using Appenders;
    using Formatters;


    class Program
    {
        static void Main(string[] args)
        {
            var formatter = new XmlFormatter();
            var appender = new ConsoleAppender(formatter);
            var logger = new Logger(appender);

            logger.Info("This is app");
            logger.Error("Cannot be empty!");
            logger.Critical("You are illigle");
        }
    }
}
