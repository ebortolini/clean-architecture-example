namespace Bookify.Domain.Apartments
{
    public record Money(decimal Amout, Currency Currency)
    {
        public static Money operator +(Money first, Money second)
        {
            if (first.Currency != second.Currency)
                throw new InvalidOperationException("Currencies have to be equal");

            return new Money(first.Amout + second.Amout, first.Currency);
        }

        public static Money Zero() => new Money(0, Currency.None);
    }
}
