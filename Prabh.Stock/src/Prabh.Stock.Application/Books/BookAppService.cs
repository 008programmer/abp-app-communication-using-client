using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Prabh.Stock.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;
using Volo.Abp.ObjectMapping;

namespace Prabh.Stock.Books;
public class BookAppService : ApplicationService, IBookAppService
{
    private readonly IRepository<Book, Guid> _repository;

    public BookAppService(IRepository<Book, Guid> repository)
    {
        _repository = repository;
    }

    public async Task<BookDto> GetAsync(Guid id)
    {
        var book = await _repository.GetAsync(id);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    public async Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await _repository.GetQueryableAsync();
        var query = queryable
            .OrderBy(input.Sorting.IsNullOrWhiteSpace() ? "Name" : input.Sorting)
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount);

        var books = await AsyncExecuter.ToListAsync(query);
        var totalCount = await AsyncExecuter.CountAsync(queryable);

        return new PagedResultDto<BookDto>(
            totalCount,
            ObjectMapper.Map<List<Book>, List<BookDto>>(books)
        );
    }
    public async Task<PagedResultDto<StockDto>> GetThisMonthTopStocksAsync()
    {
        await Task.CompletedTask; // Simulate async operation

        List<StockM> GetMockStocks() => new List<StockM>
{
    new StockM { Ticker = "AAPL", CompanyName = "Apple Inc.", CurrentPrice = 189.12m, Change = 1.15m, PercentChange = 0.61m },
    new StockM { Ticker = "MSFT", CompanyName = "Microsoft Corp.", CurrentPrice = 412.23m, Change = -2.50m, PercentChange = -0.60m },
    new StockM { Ticker = "GOOGL", CompanyName = "Alphabet Inc.", CurrentPrice = 132.50m, Change = 0.98m, PercentChange = 0.75m },
    new StockM { Ticker = "AMZN", CompanyName = "Amazon.com Inc.", CurrentPrice = 176.44m, Change = 3.30m, PercentChange = 1.91m },
    new StockM { Ticker = "TSLA", CompanyName = "Tesla Inc.", CurrentPrice = 175.85m, Change = -1.80m, PercentChange = -1.01m },
    new StockM { Ticker = "NFLX", CompanyName = "Netflix Inc.", CurrentPrice = 652.14m, Change = 5.10m, PercentChange = 0.79m },
    new StockM { Ticker = "NVDA", CompanyName = "NVIDIA Corp.", CurrentPrice = 1050.66m, Change = 15.30m, PercentChange = 1.48m }
};

        var stocks = GetMockStocks();
        var totalCount = stocks.Count;

        return new PagedResultDto<StockDto>(
            totalCount,
            ObjectMapper.Map<List<StockM>, List<StockDto>>(stocks)
        );
    }

    [Authorize(StockPermissions.Books.Create)]
    public async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {
        var book = ObjectMapper.Map<CreateUpdateBookDto, Book>(input);
        await _repository.InsertAsync(book);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    [Authorize(StockPermissions.Books.Edit)]
    public async Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        var book = await _repository.GetAsync(id);
        ObjectMapper.Map(input, book);
        await _repository.UpdateAsync(book);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    [Authorize(StockPermissions.Books.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}
