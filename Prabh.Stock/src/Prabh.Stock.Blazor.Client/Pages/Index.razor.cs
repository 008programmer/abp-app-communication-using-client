using Microsoft.AspNetCore.Components;
using Prabh.Stock.Books;
using System.Threading.Tasks;

namespace Prabh.Stock.Blazor.Client.Pages;

public partial class Index
{

    [Inject] public IStockAppService StockAppService_Proxy { get; set; }

    public int NoofStocks { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();


        var x= await StockAppService_Proxy.GetThisMonthTopStocksAsync();

        NoofStocks = (int)x.TotalCount;

    }

}
