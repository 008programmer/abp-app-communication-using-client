using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Prabh.Stock.Blazor;

public class StockStyleBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add(new BundleFile("main.css", true));
    }
}
