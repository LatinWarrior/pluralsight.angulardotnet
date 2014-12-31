using WebMvc.Models.Courses;
using WebMvc.Models.Instructors;

namespace WebMvc.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public CourseVm[] GetCourseVms()
        {
            var courses = new[]
            {
                new CourseVm {Instructor = "Rubeus Hagrid", Name = "Care of Magical Creatures", Number = "CREA101"},
                new CourseVm {Instructor = "Severus Snape", Name = "Defense Against the Dark Arts", Number = "DARK502"},
                new CourseVm {Instructor = "Minerva McGonagall", Name = "Transfiguration", Number = "TRAN201"}
            };
            
            return courses;
        }

        public InstructorVm[] GetInstructorVms()
        {
            var instructors = new []
            {
                new InstructorVm{Name = "Rubeus Hadrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001},
                new InstructorVm{Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105},
                new InstructorVm{Name = "Minerva McGonagall", Email = "mcgonagall@hogwarts.com", RoomNumber = 102}
            };            

            return instructors;
        }
    }
}