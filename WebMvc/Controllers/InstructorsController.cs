using System.Web.Mvc;
using WebMvc.Models.Registration;

namespace WebMvc.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly RegistrationVmBuilder _registrationBuilder = new RegistrationVmBuilder();
        // GET: Instructors
        public ActionResult Index()
        {
            return View("Index", "", _registrationBuilder.GetSerializedInstructors());
        }
    }
}