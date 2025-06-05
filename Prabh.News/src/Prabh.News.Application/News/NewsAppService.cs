using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Prabh.News.Books;

public class NewsAppService : ApplicationService, INewsAppService
{
    
    public NewsAppService()
    {
        
    }

    public async Task<PagedResultDto<NewsDto>> GetTopMonthlyNewsAsync()
    {
        await Task.CompletedTask; // Simulate async operation
        List<NewsDto> newsDto =
        [
            new() {
                Id = Guid.NewGuid(),
                Title = "Project Alpha Launched",
                Summary = "Alpha is a new AI-powered project launched this month.",
                Date = DateTime.UtcNow.AddDays(-3),
                Ticker = "MSFT"
            },
            new() {
                Id = Guid.NewGuid(),
                Title = "Beta Reaches Milestone",

                Summary = "Beta project completed phase 2 of development.",
                Date = DateTime.UtcNow.AddDays(-7),
                 Ticker = "AMZN"
            },
            new() {
                Id = Guid.NewGuid(),
                Title = "Gamma Project Announced",
                Summary = "A new cloud-native project Gamma was announced.",
                Date = DateTime.UtcNow.AddDays(-1),
                 Ticker = "TSLA"
            }
        ];


        return new PagedResultDto<NewsDto>(
            newsDto.Count,
            newsDto
        );
    }

    public Task<NewsDto> CreateAsync(CreateUpdateNewsDto input)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<NewsDto> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResultDto<NewsDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        throw new NotImplementedException();
    }

    public Task<NewsDto> UpdateAsync(Guid id, CreateUpdateNewsDto input)
    {
        throw new NotImplementedException();
    }
}

