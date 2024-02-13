namespace Bookify.Domain.Abstratcions
{
    public abstract class Entity
    {
        protected Entity(Guid id)
        { 
            Id = id;
        }

        public Guid Id { get; init; }
    }
}
