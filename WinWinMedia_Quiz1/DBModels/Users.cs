using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.DBModels
{
    /// <summary>
    /// 使用者
    /// </summary>
    [Table("users")]
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("user_id")]
        public int Id { get; set; }
        /// <summary>
        /// 用戶email
        /// </summary>
        [Required]
        [StringLength(50)]
        [Column("user_email")]
        public required string Email { get; set; }
        /// <summary>
        /// 用戶名稱
        /// </summary>
        [Required]
        [StringLength(100)]
        [Column("user_password")]
        public required string PassWord { get; set; }
        /// <summary>
        /// 用戶姓名
        /// </summary>
        [Required]
        [StringLength(50)]
        [Column("user_name")]
        public required string Name { get; set; }
        /// <summary>
        /// 用戶年齡
        /// </summary>
        [Column("user_age")]
        public int? Age { get; set; }
        /// <summary>
        /// 用戶性別 (0為女，1為男)
        /// </summary>
        [Required]
        [Column("user_sex")]
        public required bool Sex { get; set; }
        /// <summary>
        /// 用戶地區 Id
        /// </summary>
        [StringLength(50)]
        [Column("user_location_id")]
        public int? LocationId{ get; set; }
        /// <summary>
        /// 用戶所屬地區Id
        /// </summary>
        public Location? Location { get; set; }
    }
}
