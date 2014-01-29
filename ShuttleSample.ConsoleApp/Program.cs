using System;
using Shuttle.Core.Infrastructure;
using Shuttle.ESB.Core;
using ShuttleSample.Messages;

namespace ShuttleSample.ConsoleApp
{
    class Program
    {
        private static IServiceBus _bus;

        static void Main()
        {
            Log.Assign(new ConsoleLog(typeof(Program)) { LogLevel = LogLevel.Trace });
            _bus = ServiceBus.Create().Start();
            var index = 1;

            while (true)
            {
                Console.ReadLine();
                
                _bus.Send(new SubmitArticleToEditor {Article = "test " + index++});
            }
        }
    }
}
