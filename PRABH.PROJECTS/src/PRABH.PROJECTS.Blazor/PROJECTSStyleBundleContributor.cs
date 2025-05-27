using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace PRABH.PROJECTS.Blazor;

public class PROJECTSStyleBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add(new BundleFile("main.css", true));
    }
}
