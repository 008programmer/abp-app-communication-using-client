using AutoMapper;
using Prabh.Stock.Books;

namespace Prabh.Stock;

public class StockApplicationAutoMapperProfile : Profile
{
    public StockApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<StockM, StockDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
