using AbpVnextDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpVnextDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpVnextDemoController : AbpController
    {
        protected AbpVnextDemoController()
        {
            LocalizationResource = typeof(AbpVnextDemoResource);
        }
    }
}