using System;
using System.Collections.Generic;
using System.Text;
using AbpVnextDemo.Localization;
using Volo.Abp.Application.Services;

namespace AbpVnextDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpVnextDemoAppService : ApplicationService
    {
        protected AbpVnextDemoAppService()
        {
            LocalizationResource = typeof(AbpVnextDemoResource);
        }
    }
}
