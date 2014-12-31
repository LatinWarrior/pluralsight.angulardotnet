using System.Web.Http;
using WebMvc.Models.Courses;
using WebMvc.Models.Registration;

namespace WebMvc.Controllers
{
    public class CoursesController : ApiController
    {
        private readonly RegistrationVmBuilder _registrationBuilder = new RegistrationVmBuilder();

        // GET: Hello
        public CourseVm[] Get()
        {
            return _registrationBuilder.GetCourseVms();
        }        
    }
}