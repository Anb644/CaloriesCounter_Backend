using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CaloriesCounter.Controllers
{
    public abstract class CaloriesCounterControllerBase: AbpController
    {
        protected CaloriesCounterControllerBase()
        {
            LocalizationSourceName = CaloriesCounterConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
