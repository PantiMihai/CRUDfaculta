using System.ComponentModel.DataAnnotations;

namespace CRUDfaculta.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        public string EmployeeIdView
        {
            get {
                return EmployeeId.ToString().PadLeft(4, '0');
            }
        }
        [Required] public string FullName { get; set; }
        [Required] public string Department { get; set; }
        [Required] public DateTime BirthDate { get; set; }
        [Required] public int Age { get; set; }
        [Required] public string PhoneNumber { get; set; }
    }
}
