using Bookify.Domain.Abstratcions;

namespace Bookify.Domain.Bookings.Events
{
    public sealed record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;
}
