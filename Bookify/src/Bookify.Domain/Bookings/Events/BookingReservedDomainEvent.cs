using Bookify.Domain.Abstratcions;

namespace Bookify.Domain.Bookings.Events
{
    public sealed record BookingReservedDomainEvent (Guid BookingId) : IDomainEvent;
}