using System.Net;
using System.Web.Http;
using System.Web.Mvc;
using WebMvc.Models.Students;

namespace WebMvc.Controllers
{
    public class AccountController : ApiController
    {
        [System.Web.Mvc.HttpPost]
        public ActionResult Save(StudentVm student)
        {
            // _studentRegistrationService.Register(student);
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}