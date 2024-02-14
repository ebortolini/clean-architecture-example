﻿using Bookify.Domain.Abstratcions;

namespace Bookify.Domain.Bookings.Events
{
    public sealed record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;
}
