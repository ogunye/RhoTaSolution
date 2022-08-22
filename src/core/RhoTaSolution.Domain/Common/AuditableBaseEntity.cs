using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(50, ErrorMessage = "Maximum character length is 50")]
        public string? CreatedBy { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [StringLength(50, ErrorMessage = "Maximum character length is 50")]
        public string? ModifiedBy { get; set; }
                
        [DataType(DataType.Date)]
        public DateTime DateModified { get; set; }
        public bool IsDelete { get; set; }
    }
}
