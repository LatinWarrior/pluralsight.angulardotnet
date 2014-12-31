using System.Web.Mvc;
using WebMvc.Models.Registration;

namespace WebMvc.Controllers
{
    public class InstructorsController : JsonController
    {
        private readonly RegistrationVmBuilder _registrationBuilder = new RegistrationVmBuilder();
        // GET: Instructors
        public ActionResult Index()
        {
            return Json(_registrationBuilder.GetInstructorVms(), JsonRequestBehavior.AllowGet);
        }
    }
}