namespace kudapoyti.Service.Common.Utils;

public class PaginationMetaData
{
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public bool HasNext { get; set; }
    public bool HasPrevious { get; set; }
    public int PageSize { get;  set; }
    public int TotalItems { get; set; }

    public PaginationMetaData(int pageIndex, int pageSize, int totalCount)
    {
        CurrentPage =(int)pageIndex;
        TotalPages =(int)Math.Ceiling((double)(totalCount + pageSize-1) / pageSize);
        HasNext = pageIndex<TotalPages;
        HasPrevious = pageIndex > 1;
        PageSize = pageSize;
    
    }
}
 