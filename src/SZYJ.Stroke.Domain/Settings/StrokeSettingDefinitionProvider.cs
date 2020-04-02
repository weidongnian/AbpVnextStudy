using Volo.Abp.Settings;

namespace SZYJ.Stroke.Settings
{
    public class StrokeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(StrokeSettings.MySetting1));
        }
    }
}
