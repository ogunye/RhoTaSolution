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
    public class Hospital : BaseEntity
    {
        [Required(ErrorMessage = "This is a required field.")]
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string Hospital_Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Hospital_Medical_Director { get; set; } = String.Empty;

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        [Column("HospitalHotLine")]
        public string Hospital_Contact_number { get; set; } = string.Empty;

        public Address? Address { get; set; }

        public ICollection<Employee>? Employees { get; set; }    
    }
}
