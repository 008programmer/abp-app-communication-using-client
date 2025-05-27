using AutoMapper;
using PRABH.PEOPLE.Books;

namespace PRABH.PEOPLE.Blazor.Client;

public class PEOPLEBlazorAutoMapperProfile : Profile
{
    public PEOPLEBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}