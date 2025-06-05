using AutoMapper;
using Prabh.News.Books;

namespace Prabh.News.Blazor.Client;

public class NewsBlazorAutoMapperProfile : Profile
{
    public NewsBlazorAutoMapperProfile()
    {
        CreateMap<NewsDto, CreateUpdateNewsDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}