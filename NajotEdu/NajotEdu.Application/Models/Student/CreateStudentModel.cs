using System.ComponentModel.DataAnnotations;

namespace NajotEdu.Application.Models
{
    public class CreateStudentModel
    {
        [Required]
        public string FullName { get; set; } = default;
        public DateTimeOffset BirthDate { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = default;
    }
}
