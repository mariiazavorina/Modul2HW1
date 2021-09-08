using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW1
{
    public class Actions
    {
        private readonly Logger _logger = Logger.GetInstance;
        public bool InfoCheck()
        {
            _logger.Get("Info", "Start method: InfoCheck");
            var result = new Result();
            result.Status = true;
            return result.Status;
        }

        public bool WarningCheck()
        {
            _logger.Get("Warning", "Skipped logic in method: WarningCheck");
            var result = new Result();
            result.Status = true;
            return result.Status;
        }

        public bool MistakesCheck()
        {
            var result = new Result();
            result.Status = false;
            return result.Status;
        }
    }
}
