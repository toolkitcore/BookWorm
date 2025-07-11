﻿using BookWorm.SharedKernel.Helpers;
using MassTransit;

namespace BookWorm.Chassis.EventBus;

[ExcludeFromTopology]
public abstract record IntegrationEvent
{
    public Guid Id { get; } = Guid.CreateVersion7();

    public DateTime CreationDate { get; } = DateTimeHelper.UtcNow();
}
