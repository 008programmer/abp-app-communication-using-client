using Microsoft.AspNetCore.Authorization;
using Prabh.Stock.Stocks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Prabh.Stock.Books;


[AllowAnonymous]
public class StockAppService : ApplicationService /*CrudAppService<XStock, StockDto, Guid>*/, IStockAppService
{
    private readonly IRepository<XStock, Guid> _repository;

    public StockAppService() 
    {
        
    }

    public async Task<PagedResultDto<StockDto>> GetThisMonthTopStocksAsync()
    {

        await Task.CompletedTask; // Simulate async operation

        var stocks = GetMockStocks();
        var totalCount = stocks.Count;

        return new PagedResultDto<StockDto>(
            totalCount,
            ObjectMapper.Map<List<XStock>, List<StockDto>>(stocks)
        );
    }

    private static List<XStock> GetMockStocks() =>
    [
        new() { Ticker = "AAPL", CompanyName = "Apple Inc.", CurrentPrice = 189.12m, Change = 1.15m, PercentChange = 0.61m },
        new() { Ticker = "MSFT", CompanyName = "Microsoft Corp.", CurrentPrice = 412.23m, Change = -2.50m, PercentChange = -0.60m },
        new() { Ticker = "GOOGL", CompanyName = "Alphabet Inc.", CurrentPrice = 132.50m, Change = 0.98m, PercentChange = 0.75m },
        new() { Ticker = "AMZN", CompanyName = "Amazon.com Inc.", CurrentPrice = 176.44m, Change = 3.30m, PercentChange = 1.91m },
        new() { Ticker = "TSLA", CompanyName = "Tesla Inc.", CurrentPrice = 175.85m, Change = -1.80m, PercentChange = -1.01m },
        new() { Ticker = "NFLX", CompanyName = "Netflix Inc.", CurrentPrice = 652.14m, Change = 5.10m, PercentChange = 0.79m },
        new() { Ticker = "NVDA", CompanyName = "NVIDIA Corp.", CurrentPrice = 1050.66m, Change = 15.30m, PercentChange = 1.48m }
    ];

    public Task<StockDto> CreateAsync(CreateUpdateBookDto input)
    {
        throw new NotImplementedException();
    }

    public Task<StockDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        throw new NotImplementedException();
    }

    public Task<StockDto> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResultDto<StockDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
