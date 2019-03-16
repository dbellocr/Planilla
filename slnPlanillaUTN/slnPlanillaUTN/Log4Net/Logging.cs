using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnPlanillaUTN
{
    public class Logging
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Logging));
        static Logging()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public static void LogError(string exception)
        {
            log.Error(exception);
        }

    }
}
