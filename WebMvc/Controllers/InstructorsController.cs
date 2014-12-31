using System.Web.Http;
using WebMvc.Models.Instructors;
using WebMvc.Models.Registration;

namespace WebMvc.Controllers
{
    public class InstructorsController : ApiController
    {
        private readonly RegistrationVmBuilder _registrationBuilder = new RegistrationVmBuilder();

        // GET: Instructors
        public InstructorVm[] Get()
        {
            return _registrationBuilder.GetInstructorVms();
        }
    }
}