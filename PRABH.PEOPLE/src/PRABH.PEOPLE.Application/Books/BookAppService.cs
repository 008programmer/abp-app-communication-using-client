using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PRABH.PEOPLE.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;

namespace PRABH.PEOPLE.Books;

//[Authorize(PEOPLEPermissions.Books.Default)]
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

    public async Task<PagedResultDto<EmployeeDto>> GetEmployeesAsync()
    {
        var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Alice Johnson", Department = "HR", JoiningDate = new DateTime(2022, 1, 15) },
    new Employee { Id = 2, Name = "Bob Smith", Department = "IT", JoiningDate = new DateTime(2021, 5, 23) },
    new Employee { Id = 3, Name = "Carol Lee", Department = "Finance", JoiningDate = new DateTime(2020, 8, 10) },
    new Employee { Id = 4, Name = "David Kumar", Department = "Marketing", JoiningDate = new DateTime(2023, 3, 1) },
    new Employee { Id = 5, Name = "Eva Green", Department = "Sales", JoiningDate = new DateTime(2022, 11, 7) }
};


        var queryable = employees.AsQueryable();
        var query = queryable
            .OrderBy(x => x.Name);

        var books = await AsyncExecuter.ToListAsync(query);
        var totalCount = await AsyncExecuter.CountAsync(queryable);

        return new PagedResultDto<EmployeeDto>(
            totalCount,
            ObjectMapper.Map<List<Employee>, List<EmployeeDto>>(books)
        );
    }

    //[Authorize(PEOPLEPermissions.Books.Create)]
    public async Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {
        var book = ObjectMapper.Map<CreateUpdateBookDto, Book>(input);
        await _repository.InsertAsync(book);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    //[Authorize(PEOPLEPermissions.Books.Edit)]
    public async Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        var book = await _repository.GetAsync(id);
        ObjectMapper.Map(input, book);
        await _repository.UpdateAsync(book);
        return ObjectMapper.Map<Book, BookDto>(book);
    }

    //[Authorize(PEOPLEPermissions.Books.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }
}
