using AutoMapper;
using Prabh.News.Books;

namespace Prabh.News;

public class NewsApplicationAutoMapperProfile : Profile
{
    public NewsApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
