using System.Net;
using System.Web.Mvc;
using WebMvc.Models.Students;

namespace WebMvc.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Save(StudentVm student)
        {
            // _studentRegistrationService.Register(student);
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}