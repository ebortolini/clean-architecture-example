namespace Bookify.Domain.Abstratcions
{
    public abstract class Entity
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        
        protected Entity(Guid id)
        { 
            Id = id;
        }

        protected Entity() { }

        public Guid Id { get; init; }

        public IReadOnlyList<IDomainEvent> GetDomainEvents() => _domainEvents.ToList();

        public void CleanDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent) 
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
