using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebMvc.Models.Students;

namespace WebMvc.Controllers
{
    public class AccountController : ApiController
    {       
        public HttpResponseMessage Post(HttpRequestMessage request, StudentVm student)
        {
            // _studentRegistrationService.Register(student);

            if (student == null)
            {
                return request.CreateResponse(HttpStatusCode.BadRequest, new List<string> { "Account information must be provided." });
            }

            if (ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }            

            return request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
        }

        private IEnumerable<string> GetErrorMessages()
        {
            var errorMessages = ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage));
            return errorMessages;
        }
    }
}