using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PRABH.PROJECTS.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;

namespace PRABH.PROJECTS.Books;

//[Authorize(PROJECTSPermissions.Books.Default)]
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


    public async Task<PagedResultDto<ProjectDto>> GetProjectsAsync()
    {
        var projects = new List<Project>
{
    new Project
    {
        Name = "Project 1",
        StartTime = "2023-01-01",
        EndTime = "2023-12-31",
        WeeklyHours = 40
    },
    new Project
    {
        Name = "Project 2",
        StartTime = "2023-02-01",
        EndTime = "2023-11-30",
        WeeklyHours = 35
    },
    new Project
    {
        Name = "Project 3",
        StartTime = "2023-03-15",
        EndTime = "2023-09-15",
        WeeklyHours = 20
    }
};

        var queryable = projects.AsQueryable();
        var query = queryable
            .OrderBy(x => x.Name);

        var books = await AsyncExecuter.ToListAsync(query);
        var totalCount = await AsyncExecuter.CountAsync(queryable);

        return new PagedResultDto<ProjectDto>(
            totalCount,
            ObjectMapper.Map<List<Project>, List<ProjectDto>>(books)
        );
    }

    //[Authorize(PROJECTSPermissions.Books.Create)]
    public async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {
        var book = ObjectMapper.Map<CreateUpdateBookDto, Book>(input);
        await _repository.InsertAsync(book);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    //[Authorize(PROJECTSPermissions.Books.Edit)]
    public async Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        var book = await _repository.GetAsync(id);
        ObjectMapper.Map(input, book);
        await _repository.UpdateAsync(book);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    //[Authorize(PROJECTSPermissions.Books.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}
