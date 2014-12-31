using System.Web.Mvc;
using WebMvc.Models.Registration;

namespace WebMvc.Controllers
{
    public class CoursesController : JsonController
    {
        private readonly RegistrationVmBuilder _registrationBuilder = new RegistrationVmBuilder();
        // GET: Hello
        public ActionResult Index()
        {
            return Json(_registrationBuilder.GetCourseVms(), JsonRequestBehavior.AllowGet);
        }        
    }
}