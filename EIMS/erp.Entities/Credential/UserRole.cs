using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Erp.Entities.Bases;


namespace Erp.Entities.Credential
{
    [Table("usr_UserRole")]
    public class UserRole : BaseEntityByNo
    {
        [ForeignKey("UserMaster")]
        public Guid UserID { get; set; }

        [ForeignKey("Role")]
        public Guid RoleID { get; set; }

        public virtual UserMaster UserMaster { get; set; }
        public virtual Role Role { get; set; }
    }
}