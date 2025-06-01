using Blazorise;
using Microsoft.AspNetCore.Components;
using Prabh.News.Books;
using Prabh.Stock.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Alerts;

namespace Prabh.Finance.Blazor.Client.Pages;


public record LatestStockNews(string Ticker, string CompanyName, decimal CurrentPrice, string Summary);


public partial class Index
{

    [Inject] public IStockAppService StockAppService_HTTP { get; set; }

    [Inject] public INewsAppService NewsAppService_HTTP { get; set; }

    [Inject]  IMessageService MessageService { get; set; }


    private List<LatestStockNews> LatestStockNews = [];
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        try
        {
            var stockResponse = await StockAppService_HTTP.GetThisMonthTopStocksAsync();
            var newsResponse = await NewsAppService_HTTP.GetTopMonthlyNewsAsync();

            LatestStockNews = [.. from s in stockResponse.Items.ToList()
                                           join n in newsResponse.Items.ToList() on s.Ticker equals n.Ticker
                                           select new LatestStockNews(s.Ticker, s.CompanyName, s.CurrentPrice, n.Summary)];
        }
        catch (System.Exception ex)
        {
            //This is just to mange eror If any external apis are not working or not reachable.
            MessageService?.Error("Error calling Stock Or New APis. See Console for me error");
            Console.WriteLine("[Err] : " +  ex.Message ?? ex.InnerException.Message);
        }
    }
}
