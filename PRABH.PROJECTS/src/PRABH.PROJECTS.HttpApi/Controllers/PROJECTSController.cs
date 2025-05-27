using PRABH.PROJECTS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PRABH.PROJECTS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PROJECTSController : AbpControllerBase
{
    protected PROJECTSController()
    {
        LocalizationResource = typeof(PROJECTSResource);
    }
}
