using HotelBookingClean.Domain.Common;

namespace HotelBookingClean.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
