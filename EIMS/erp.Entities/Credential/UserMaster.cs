using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using erp.Entities.Bases;


namespace erp.Entities.Credential
{
    [Table("usr_UserMaster")]
    public class UserMaster : BaseEntity
    {
        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [Required]
        public int TypeID { get; set; }

        //public virtual UserCredential UserCredential { get; set; }

        //public virtual ICollection<UserRole> UserRoles { get; set; }


    }

    public class UserMasterDTO
    {
        public Guid ID { get; set; }
        public int UserTypeID { get; set; }
        public string MobileNo { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public string Upazilla { get; set; }
        public string Union { get; set; }
    }
}