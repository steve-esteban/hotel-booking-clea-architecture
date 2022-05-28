using System.Globalization;
using HotelBookingClean.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace HotelBookingClean.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
