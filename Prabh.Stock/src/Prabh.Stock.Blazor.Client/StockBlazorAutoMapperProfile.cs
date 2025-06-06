using AutoMapper;
using Prabh.Stock.Books;

namespace Prabh.Stock.Blazor.Client;

public class StockBlazorAutoMapperProfile : Profile
{
    public StockBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}