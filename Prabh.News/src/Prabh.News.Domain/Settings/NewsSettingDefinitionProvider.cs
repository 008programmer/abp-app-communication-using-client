using Volo.Abp.Settings;

namespace Prabh.News.Settings;

public class NewsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NewsSettings.MySetting1));
    }
}
