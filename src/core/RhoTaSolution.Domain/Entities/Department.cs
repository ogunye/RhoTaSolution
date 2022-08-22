using RhoTaSolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Domain.Entities
{
    public class Department : BaseEntity
    {
        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum character length is 50")]
        public string? Department_Name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum character length is 500")]
        public string? Department_Description { get; set; }

        public ICollection<JobTitle>? JobTitles { get; set; }
    }
}
