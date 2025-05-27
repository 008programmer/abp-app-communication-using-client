using AutoMapper;
using PRABH.PROJECTS.Books;

namespace PRABH.PROJECTS.Blazor.Client;

public class PROJECTSBlazorAutoMapperProfile : Profile
{
    public PROJECTSBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}