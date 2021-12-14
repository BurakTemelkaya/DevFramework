using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class SerializableLogEvent
    {
        private readonly LoggingEvent _logginEvent;

        public SerializableLogEvent(LoggingEvent logginEvent)
        {
            _logginEvent = logginEvent;
        }
        public string UserName => _logginEvent.UserName;
        public object MessageObject => _logginEvent.MessageObject;


    }
}
