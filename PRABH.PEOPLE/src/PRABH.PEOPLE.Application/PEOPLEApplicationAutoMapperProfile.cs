using AutoMapper;
using PRABH.PEOPLE.Books;

namespace PRABH.PEOPLE;

public class PEOPLEApplicationAutoMapperProfile : Profile
{
    public PEOPLEApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
