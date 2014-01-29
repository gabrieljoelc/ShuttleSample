using Shuttle.Core.Infrastructure;
using Shuttle.ESB.Core;

namespace ShuttleSample.Web.App_Start
{
    public class Bus
    {
        internal static IServiceBus Instance { get; private set; }

        public static void Start()
        {
            Log.Assign(new ConsoleLog(typeof (MvcApplication)) { LogLevel = LogLevel.Trace});
            Instance = ServiceBus.Create().Start();
        }

        public static void Stop()
        {
            Instance.Dispose();
        }
    }
}