using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View("Index", "", GetSerializedCourseVms());
        }

        public string GetSerializedCourseVms()
        {
            var courses = new[]
            {
                new CourseVm
                {
                    Instructor = "Rubeus Hagrid",
                    Name = "Care of Magical Creatures",
                    Number = "CREA101"
                },
                new CourseVm
                {
                    Instructor = "Severus Snape",
                    Name = "Defense Against the Dark Arts",
                    Number = "DARK502"
                },
                new CourseVm
                {
                    Instructor = "Minerva McGonagall",
                    Name = "Transfiguration",
                    Number = "TRAN201"
                }
            };

            var settings = new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()};

            var serializedObject = JsonConvert.SerializeObject(courses, Formatting.None, settings);

            return serializedObject;
        }
    }
}