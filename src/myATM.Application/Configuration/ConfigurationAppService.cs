using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using myATM.Configuration.Dto;

namespace myATM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : myATMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
