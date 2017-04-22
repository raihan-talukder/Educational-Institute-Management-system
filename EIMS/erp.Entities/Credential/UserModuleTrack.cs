using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.Entities.Bases;

namespace Erp.Entities.Credential
{
    [Table("usr_UserModuleTrack")]
    public class UserModuleTrack : BaseEntity
    {
        public int ModuleID { get; set; }
        public Guid UserID { get; set; }

        public DateTime ActivationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }

        [ForeignKey("UserID")]
        public UserMaster User { get; set; }
    }
}