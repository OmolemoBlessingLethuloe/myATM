using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace myATM.Controllers
{
    public abstract class myATMControllerBase: AbpController
    {
        protected myATMControllerBase()
        {
            LocalizationSourceName = myATMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
