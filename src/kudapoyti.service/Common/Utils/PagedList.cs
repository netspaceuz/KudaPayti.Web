using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudapoyti.Service.Common.Utils;

public class PagedList<T> : List<T>
{
    public PaginationMetaData MetaData { get; set; } = default!;

    public PagedList(List<T> items, PaginationParams @params, int totalItems)
    {
        this.MetaData = new PaginationMetaData(@params.PageNumber, @params.PageSize, totalItems);
        AddRange(items);

    }

    public static async Task<PagedList<T>> ToPagedListAsync(IQueryable<T> source,PaginationParams @params)
    {
        int totalAmount=source.Count();
        var query = await source.Skip((@params.PageNumber - 1) * @params.PageSize)
            .Take(@params.PageSize)
            .ToListAsync();
        return new PagedList<T>(query, @params, totalAmount);
    }
}
