using RhoTaSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Application.DataTransferObjects.HospitalDTO
{
    public class HospitalDto
    {
        [Display(Name ="Serial Number")]
        public int Id { get; set; }

        [Display(Name ="Address")]
        public int AddressId { get; set; }

        [Display(Name = "Hospital Name")]
        public string? Hospital_Name { get; set; }

        [Display(Name = "Medical Director")]
        public string? Hospital_Medical_Director { get; set; }

        [Display(Name ="Hospital Line")]
        public string Hospital_Contact_number { get; set; } = string.Empty;

        public Address? Address { get; set; }
    }
}
