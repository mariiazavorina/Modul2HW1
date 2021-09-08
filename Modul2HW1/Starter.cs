using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modul2HW1
{
    public class Starter
    {
        private readonly Logger _logger = Logger.GetInstance;
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                var rand = new Random().Next(1, 4);
                switch (rand)
                {
                    case 1:
                        var getInfo = new Actions();
                        bool infoResult = getInfo.InfoCheck();
                        break;
                    case 2:
                        var getWarning = new Actions();
                        bool warningResult = getWarning.WarningCheck();
                        break;
                    default:
                        var getMistakes = new Actions();
                        bool mistakesResult = getMistakes.MistakesCheck();
                        _logger.Get("Error", "Action failed by a reason: I broke logic!");
                        break;
                }
            }

            File.WriteAllText("log.txt", _logger.Save().ToString());
        }
    }
}
