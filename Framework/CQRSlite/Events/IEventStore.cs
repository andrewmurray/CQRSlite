﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSlite.Events
{
    public interface IEventStore
    {
        Task Save(Guid aggregateId, int? expectedVersion, IEnumerable<IEvent> events);
        Task<IEnumerable<IEvent>> Get(Guid aggregateId, int fromVersion);
    }
}