using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW1
{
    public sealed class Logger
    {
        private static readonly Logger Instance = new Logger();
        private readonly StringBuilder _log = new StringBuilder();
        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger GetInstance
        {
            get
            {
                return Instance;
            }
        }

        public void Get(string type, string text)
        {
            _log.AppendLine($"{DateTime.Now}: {type}: {text}");
        }

        public StringBuilder Save()
        {
            return _log;
        }
    }
}
