using HotelBookingClean.Application.Common.Interfaces;

namespace HotelBookingClean.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
