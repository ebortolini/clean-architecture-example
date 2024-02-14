using Bookify.Domain.Abstratcions;

namespace Bookify.Domain.Bookings.Events
{
    public sealed record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;
}
