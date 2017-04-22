using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Erp.Entities.Bases;
using Newtonsoft.Json;

namespace Erp.Entities.Credential
{
    [Table("usr_UserCredential")]
    public class UserCredential
    {
        [Required, Key]
        [ForeignKey("UserMaster")]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(500)]
        [JsonIgnore]
        public string Password { get; set; }

        [Required]
        [MaxLength(500)]
        [JsonIgnore]
        public string PasswordSalt { get; set; }

        [Required]
        [MaxLength(500)]
        public string Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string MobileNo { get; set; }

        public int StatusID { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public System.DateTime LastPasswordChangedDate { get; set; }
        public System.DateTime LastLoginFailedAttemptDate { get; set; }
        public int LoginFailedAttemptCount { get; set; }
        [JsonIgnore]
        public virtual UserMaster UserMaster { get; set; }
    }
}