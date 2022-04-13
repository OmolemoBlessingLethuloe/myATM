using System.Threading.Tasks;
using myATM.Configuration.Dto;

namespace myATM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
