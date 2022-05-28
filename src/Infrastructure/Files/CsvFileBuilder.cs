using System.Globalization;
using HotelBookingClean.Application.Common.Interfaces;
using HotelBookingClean.Application.TodoLists.Queries.ExportTodos;
using HotelBookingClean.Infrastructure.Files.Maps;
using CsvHelper;

namespace HotelBookingClean.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
