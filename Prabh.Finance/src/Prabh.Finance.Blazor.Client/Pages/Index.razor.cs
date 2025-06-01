using Microsoft.AspNetCore.Components;
//using Prabh.Stock.Books;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Prabh.Finance.Blazor.Client.Pages;

public partial class Index
{
    //[Inject] public IStockAppService StockAppService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        //PagedResultDto<StockDto> response = await StockAppService.GetThisMonthTopStocksAsync();


        
    }
}
