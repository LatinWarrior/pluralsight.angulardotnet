using System.Web.Mvc;
using WebMvc.Models.Registration;

namespace WebMvc.Controllers
{
    public class CoursesController : Controller
    {
        private readonly RegistrationVmBuilder _registrationBuilder = new RegistrationVmBuilder();
        // GET: Hello
        public ActionResult Index()
        {
            return View("Index", "", _registrationBuilder.GetSerializedCourses());
        }        
    }
}