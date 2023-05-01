using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using NavesPortalforWebWithCoreMvc.Controllers.AuthFromIntranetController;

namespace NavesPortalforWebWithCoreMvc.Controllers.DIS
{
    [Authorize]
    [CheckSession]
    public class DisItpManagementController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Project Information";
            return View();
        }
    }
}
