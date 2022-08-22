using RhoTaSolution.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RhoTaSolution.Domain.Entities
{
    public class JobTitle : AuditableBaseEntity
    {
        [ForeignKey(nameof(Employee))]
        [Required(ErrorMessage = "This is a required field.")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(Department))]
        public int Department_Id { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum character is 50")]
        [Required(ErrorMessage = "This is a required field.")]
        public string? JobTitle_Name { get; set; }

        [MaxLength(500, ErrorMessage = "Maximum character is 500")]
        public string? JobTitle_Description { get; set; }
      
        public DateTime DateJoined { get; set; }
        public DateTime DateExited { get; set; }        

        public Department? Department { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
