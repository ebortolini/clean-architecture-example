using Bookify.Domain.Abstratcions;

namespace Bookify.Domain.Reviews.Events
{
    public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;
}
