using PRABH.PROJECTS.Localization;
using Volo.Abp.Application.Services;

namespace PRABH.PROJECTS;

/* Inherit your application services from this class.
 */
public abstract class PROJECTSAppService : ApplicationService
{
    protected PROJECTSAppService()
    {
        LocalizationResource = typeof(PROJECTSResource);
    }
}
