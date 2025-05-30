using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Prabh.News.Blazor;

public class NewsStyleBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add(new BundleFile("main.css", true));
    }
}
