using RhoTaSolution.Domain.Common;

namespace RhoTaSolution.Domain.Entities
{
    public class Appointment : AuditableBaseEntity
    {
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? AppointmentStatus { get; set; }
    }
}
