using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebMvc.Models.Students;

namespace WebMvc.Controllers
{
    public class AccountController : ApiController
    {       
        public HttpResponseMessage Post(StudentVm student)
        {
            // _studentRegistrationService.Register(student);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}