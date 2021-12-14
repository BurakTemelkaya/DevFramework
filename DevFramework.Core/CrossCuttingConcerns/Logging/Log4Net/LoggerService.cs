using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net
{
    public class LoggerService
    {
        private readonly ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }
        public bool IsInfoEnable => _log.IsInfoEnabled;
        public bool IsDebugEnable => _log.IsDebugEnabled;
        public bool IsWarnEnable => _log.IsWarnEnabled;
        public bool IsFatalEnable => _log.IsFatalEnabled;
        public bool IsErrorEnable => _log.IsErrorEnabled;
        public void Info(object logMessage)
        {
            if (IsInfoEnable)
            {
                _log.Info(logMessage);
            }
        }
        public void Debug(object logMessage)
        {
            if (IsDebugEnable)
            {
                _log.Debug(logMessage);
            }
        }
        public void Warn(object logMessage)
        {
            if (IsWarnEnable)
            {
                _log.Warn(logMessage);
            }
        }
        public void Fatal(object logMessage)
        {
            if (IsInfoEnable)
            {
                _log.Fatal(logMessage);
            }
        }
        public void Error(object logMessage)
        {
            if (IsErrorEnable)
            {
                _log.Error(logMessage);
            }
        }

    }
}
