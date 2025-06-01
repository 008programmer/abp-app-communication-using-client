using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Prabh.News.Books;

public interface INewsAppService :
    ICrudAppService< //Defines CRUD methods
        NewsDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto> //Used to create/update a book
{
    Task<PagedResultDto<NewsDto>> GetTopMonthlyNewsAsync();
}