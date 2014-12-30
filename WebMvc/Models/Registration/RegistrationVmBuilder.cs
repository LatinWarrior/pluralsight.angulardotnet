using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebMvc.Models.Courses;
using WebMvc.Models.Instructors;

namespace WebMvc.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public RegistrationVm BuildRegistrationVm()
        {
            var registrationVm = new RegistrationVm
            {
                Courses = GetSerializedCourses(),
                Instructors = GetSerializedInstructors()
            };

            return registrationVm;
        }

        public string GetSerializedCourses()
        {
            var courses = new[]
            {
                new CourseVm {Instructor = "Rubeus Hagrid", Name = "Care of Magical Creatures", Number = "CREA101"},
                new CourseVm {Instructor = "Severus Snape", Name = "Defense Against the Dark Arts", Number = "DARK502"},
                new CourseVm {Instructor = "Minerva McGonagall", Name = "Transfiguration", Number = "TRAN201"}
            };

            var settings = new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()};

            var serializedObject = JsonConvert.SerializeObject(courses, Formatting.None, settings);

            return serializedObject;
        }

        public string GetSerializedInstructors()
        {
            var instructors = new []
            {
                new InstructorVm{Name = "Rubeus Hadrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001},
                new InstructorVm{Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105},
                new InstructorVm{Name = "Minerva McGonagall", Email = "mcgonagall@hogwarts.com", RoomNumber = 102}
            };

            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var serializedObject = JsonConvert.SerializeObject(instructors, Formatting.None, settings);

            return serializedObject;
        }
    }
}