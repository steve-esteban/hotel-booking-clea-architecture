using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotelBookingClean.Application.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingClean.Application.Common.Mappings;

public static class MappingExtensions
{
    public static Task<PaginatedList<TDestination>> PaginatedListAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int pageSize)
        => PaginatedList<TDestination>.CreateAsync(queryable, pageNumber, pageSize);

    public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, IConfigurationProvider configuration)
        => queryable.ProjectTo<TDestination>(configuration).ToListAsync();
}
