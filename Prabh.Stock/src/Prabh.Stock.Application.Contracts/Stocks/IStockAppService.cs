using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Prabh.Stock.Books;

public interface IStockAppService :
    ICrudAppService< //Defines CRUD methods
        StockDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateStockDto> //Used to create/update a book
{
    Task<PagedResultDto<StockDto>> GetThisMonthTopStocksAsync();
}