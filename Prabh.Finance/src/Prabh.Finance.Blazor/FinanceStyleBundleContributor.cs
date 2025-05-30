using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Prabh.Finance.Blazor;

public class FinanceStyleBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add(new BundleFile("main.css", true));
    }
}
