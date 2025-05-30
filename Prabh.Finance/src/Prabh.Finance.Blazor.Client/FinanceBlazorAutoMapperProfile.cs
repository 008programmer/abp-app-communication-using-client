using AutoMapper;
using Prabh.Finance.Books;

namespace Prabh.Finance.Blazor.Client;

public class FinanceBlazorAutoMapperProfile : Profile
{
    public FinanceBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}