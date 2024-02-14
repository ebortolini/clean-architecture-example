namespace Bookify.Domain.Abstratcions
{
    public record Error(string Code, String Name)
    {
        public static Error None = new(string.Empty, string.Empty);

        public static Error NullValue = new("Error.NullValue", "Null value was provided");
    }
}
