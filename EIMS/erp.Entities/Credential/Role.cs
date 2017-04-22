using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Erp.Entities.Bases;


namespace Erp.Entities.Credential
{
    [Table("usr_Role")]
    public class Role : BaseEntityByNo
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}