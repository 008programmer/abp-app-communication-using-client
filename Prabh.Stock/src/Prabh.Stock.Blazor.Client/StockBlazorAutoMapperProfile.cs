using AutoMapper;
using Prabh.Stock.Books;

namespace Prabh.Stock.Blazor.Client;

public class StockBlazorAutoMapperProfile : Profile
{
    public StockBlazorAutoMapperProfile()
    {
        CreateMap<StockDto, CreateUpdateStockDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}