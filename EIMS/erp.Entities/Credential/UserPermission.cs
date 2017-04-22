using System;
using System.ComponentModel.DataAnnotations.Schema;
using Erp.Entities.Bases;


namespace Erp.Entities.Credential
{
    [Table("usr_UserPermission")]
    public class UserPermission : BaseEntity
    {
        public int PermissionNo { get; set; }

        [ForeignKey("UserMaster")]
        public Guid UserID { get; set; }

        public virtual UserMaster UserMaster { get; set; }

    }
}