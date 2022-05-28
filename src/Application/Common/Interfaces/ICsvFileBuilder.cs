using HotelBookingClean.Application.TodoLists.Queries.ExportTodos;

namespace HotelBookingClean.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
