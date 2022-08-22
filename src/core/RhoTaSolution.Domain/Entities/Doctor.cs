using RhoTaSolution.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RhoTaSolution.Domain.Entities
{
    public class Doctor : AuditableBaseEntity
    {
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        [ForeignKey(nameof(Department))]
        public int DepartmentID { get; set; }
        public Address? Address { get; set; }
        public Department? Department { get; set; }

        public string? FirstNamme { get; set; }
        public string? LastNamme { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Gender { get; set; }
        public float  ChargesPerVisit { get; set; }
        public string? Specialization { get; set; }

    }
}

