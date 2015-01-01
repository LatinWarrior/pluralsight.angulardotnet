using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace WebMvc.Models.Students
{
    public class StudentVm
    {
        [Required(ErrorMessage = "Please enter a First Name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter an Email address.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid Email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a Password.")]
        public string Password { get; set; }
    }
}