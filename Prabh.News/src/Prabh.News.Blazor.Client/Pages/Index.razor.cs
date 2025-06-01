using Microsoft.AspNetCore.Components;
using Prabh.News.Books;
using System.Threading.Tasks;

namespace Prabh.News.Blazor.Client.Pages;

public partial class Index
{

    [Inject] public INewsAppService NewsAppService { get; set; }

    public int TotalCount { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var x = await NewsAppService.GetTopMonthlyNewsAsync();

        TotalCount = (int)x.TotalCount;
    }

}
