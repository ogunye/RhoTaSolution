using RhoTaSolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Domain.Entities
{
    public class Address : BaseEntity
    {
        [Required(ErrorMessage = "This is a required field.")]
        [Range(1, 500, ErrorMessage = "Number is between 1 and 500")]
        public int House_number { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Street_name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Area_locality { get; set; } = null;

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Zip_postalcode { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Province_State { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Country { get; set; }
    }
}
