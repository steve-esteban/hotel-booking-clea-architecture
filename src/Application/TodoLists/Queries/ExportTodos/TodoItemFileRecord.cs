using HotelBookingClean.Application.Common.Mappings;
using HotelBookingClean.Domain.Entities;

namespace HotelBookingClean.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
