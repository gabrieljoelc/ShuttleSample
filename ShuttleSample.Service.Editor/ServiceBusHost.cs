﻿using System;
using Shuttle.Core.Host;
using Shuttle.Core.Infrastructure;
using Shuttle.ESB.Core;

namespace ShuttleSample.Service.Editor
{
    public class ServiceBusHost : IHost, IDisposable
    {
        private IServiceBus _bus;

        public void Start()
        {
            Log.Assign(new ConsoleLog(GetType()) {LogLevel = LogLevel.Trace});
            _bus = ServiceBus.Create().Start();
        }

        public void Dispose()
        {
            _bus.Dispose();
        }
    }
}
