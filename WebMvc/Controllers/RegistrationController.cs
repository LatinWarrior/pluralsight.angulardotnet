using System.Web.Mvc;
using WebMvc.Models.Registration;

namespace WebMvc.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly RegistrationVmBuilder _registrationBuilder = new RegistrationVmBuilder();
        // GET: Registration
        public ActionResult Index()
        {
            var view = _registrationBuilder.BuildRegistrationVm();
            return View(view);
        }
    }
}