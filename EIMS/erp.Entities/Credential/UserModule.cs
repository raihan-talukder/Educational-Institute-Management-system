using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.Entities.Bases;
using Erp.Entities.Credential;

namespace Erp.Entities.Credential
{
    [Table("usr_UserModule")]
    public class UserModule : BaseEntity
    {
        public int ModuleID { get; set; }
        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public UserMaster User { get; set; }
    }
}