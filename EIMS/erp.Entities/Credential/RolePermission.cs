using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Erp.Entities.Bases;


namespace Erp.Entities.Credential
{
    [Table("usr_RolePermission")]
    public class RolePermission : BaseEntity
    {
        public int PermissionNo { get; set; }

        [ForeignKey("Role")]
        public Guid RoleID { get; set; }

        public virtual Role Role { get; set; }
    }
}