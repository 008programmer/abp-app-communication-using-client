using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace PRABH.PEOPLE.Blazor;

public class PEOPLEStyleBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add(new BundleFile("main.css", true));
    }
}
