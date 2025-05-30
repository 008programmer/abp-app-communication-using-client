using AutoMapper;
using Prabh.Finance.Books;

namespace Prabh.Finance;

public class FinanceApplicationAutoMapperProfile : Profile
{
    public FinanceApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
