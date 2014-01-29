using System;
using PublishSubscribe.Messages;
using Shuttle.Core.Data;
using Shuttle.Core.Host;
using Shuttle.Core.Infrastructure;
using Shuttle.ESB.Core;
using Shuttle.ESB.Modules.SystemException;
using Shuttle.ESB.SqlServer;

namespace PublishSubscribe.Subscriber1
{
    public class ServiceBusHost : IHost, IDisposable
    {
        private IServiceBus bus;

        public void Dispose()
        {
            bus.Dispose();
        }

        public void Start()
        {
			Log.Assign(new ConsoleLog(typeof(ServiceBusHost)) { LogLevel = LogLevel.Trace });

            ConnectionStrings.Approve();

            var subscriptionManager = SubscriptionManager.Default();

            subscriptionManager.Subscribe(new[] {typeof (OrderCompletedEvent).FullName});

            bus = ServiceBus
                .Create()
				.SubscriptionManager(subscriptionManager)
				.AddModule(new SystemExceptionModule())
				.Start();
        }
    }
}