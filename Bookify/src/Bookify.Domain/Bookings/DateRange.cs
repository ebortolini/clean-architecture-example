using Bookify.Domain.Abstratcions;

namespace Bookify.Domain.Bookings
{
    public sealed class DateRange
    {
        private DateRange()
        {
        }

        public DateOnly Start { get; init; }

        public DateOnly End { get; init; }

        public int LengthInDays => End.DayNumber - Start.DayNumber;

        public static DateRange Create(DateOnly start, DateOnly end)
        {
            if (start > end)
            {
                throw new ApplicationException("End date precedes start date");
            }

            return new DateRange
            {
                Start = start,
                End = end
            };
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is DateRange))
                return false;
            
            var dateRange = (DateRange)obj;
            
            return dateRange.Start == Start && dateRange.End == End;
        }
    }
}
