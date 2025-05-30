using Volo.Abp.Settings;

namespace Prabh.Finance.Settings;

public class FinanceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FinanceSettings.MySetting1));
    }
}
