﻿using PA.Service.Interface;
using Serilog;
using PA.Share;

namespace PA.Service
{
    public class LoggerService : ILoggerService
    {

        private ILogger Logger { get; set; }

        public LoggerService() {
            Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.File(Fields.LogFilePath)
            .CreateLogger();
        }

        public void Error(string Message)
        {
            Logger.Error(Message);
        }

        public void Error(string Message, Exception exception)
        {
            Logger.Error(exception.Message, exception);
        }

        public void Info(string Message)
        {
            Logger.Information(Message);
        }

        public void Warn(string Message)
        {
            Logger.Warning(Message);
        }
    }
}
