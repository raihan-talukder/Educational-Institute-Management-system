using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.Entities.Bases;

namespace Erp.Entities.Credential
{
    public class UserStatus : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
    }
}
