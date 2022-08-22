using RhoTaSolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Domain.Entities
{
    public class Employee : AuditableBaseEntity
    {
        [Required(ErrorMessage = "This is a required field.")]
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }       

        [ForeignKey(nameof(JobTitle))]
        [Required(ErrorMessage = "This is a required field.")]
        public int JobTitle_Id { get; set; }

        [Required(ErrorMessage = "This is a required field. ")]
        [MaxLength(50, ErrorMessage = "Maximum character is 50")]
        public string? First_Name { get; set; }

        [Required(ErrorMessage = "This is a required field. ")]
        [MaxLength(50, ErrorMessage = "Maximum character is 50")]
        public string? Middle_Name { get; set; }

        [Required(ErrorMessage = "This is a required field. ")]
        [MaxLength(50, ErrorMessage = "Maximum character is 50")]
        public string? Last_Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "This is a required field. ")]
        [MaxLength(50, ErrorMessage = "Maximum character is 50")]
        public string? Contact_Number { get; set; }

        [Required(ErrorMessage = "This is a required field. ")]
        [MaxLength(50, ErrorMessage = "Maximum character is 50")]
        public string? Gender { get; set; }

        public bool IsActive { get; set; }
       
        public Address? Address { get; set; }
        public JobTitle? JobTitle { get; set; }
    }
}
