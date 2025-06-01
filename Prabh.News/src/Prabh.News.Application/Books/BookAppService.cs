using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Prabh.News.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;

namespace Prabh.News.Books;

[Authorize(NewsPermissions.Books.Default)]
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

    [Authorize(NewsPermissions.Books.Create)]
    public async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {
        var book = ObjectMapper.Map<CreateUpdateBookDto, Book>(input);
        await _repository.InsertAsync(book);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    [Authorize(NewsPermissions.Books.Edit)]
    public async Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        var book = await _repository.GetAsync(id);
        ObjectMapper.Map(input, book);
        await _repository.UpdateAsync(book);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    [Authorize(NewsPermissions.Books.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}

public class NewsAppService : ApplicationService, INewsAppService
{
    
    public NewsAppService()
    {
        
    }

    public async Task<PagedResultDto<NewsDto>> GetTopMonthlyNewsAsync()
    {
        List<NewsDto> newsDto =
        [
            new() {
                Id = Guid.NewGuid(),
                Title = "Project Alpha Launched",
                Summary = "Alpha is a new AI-powered project launched this month.",
                Date = DateTime.UtcNow.AddDays(-3)
            },
            new() {
                Id = Guid.NewGuid(),
                Title = "Beta Reaches Milestone",
                Summary = "Beta project completed phase 2 of development.",
                Date = DateTime.UtcNow.AddDays(-7)
            },
            new() {
                Id = Guid.NewGuid(),
                Title = "Gamma Project Announced",
                Summary = "A new cloud-native project Gamma was announced.",
                Date = DateTime.UtcNow.AddDays(-1)
            }
        ];


        return new PagedResultDto<NewsDto>(
            newsDto.Count,
            newsDto
        );
    }

    public Task<NewsDto> CreateAsync(CreateUpdateBookDto input)
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

    public Task<NewsDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        throw new NotImplementedException();
    }
}

