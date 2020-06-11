using log4net;
using System.Reflection;

namespace OAuthWCF.Assets
{
    public static class Log
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().ToString());

        public static ILog GetLogger()
        {
            return _log;
        }
    }
}