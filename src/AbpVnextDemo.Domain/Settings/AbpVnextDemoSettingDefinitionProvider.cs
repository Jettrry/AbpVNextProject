using Volo.Abp.Settings;

namespace AbpVnextDemo.Settings
{
    public class AbpVnextDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpVnextDemoSettings.MySetting1));
        }
    }
}
