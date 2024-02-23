using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models
{
    /// <summary>
    /// 創建帳戶Request Model
    /// </summary>
    public class AddUserRequestModel
    {
        /// <summary>
        /// Email
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Email { get; set; } = null!;
        /// <summary>
        /// 密碼
        /// </summary>
        [Required]
        [StringLength(50)]
        [MinLength(6)]
        public string Password { get; set; } = null!;
        /// <summary>
        /// 年齡
        /// </summary>
        public int? Age { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [StringLength(10)]
        [MinLength(2)]
        public string Name { get; set; } = null!;
        /// <summary>
        /// 性別，false:女、true:男
        /// </summary>
        public bool Sex { get; set; }
        /// <summary>
        /// 所在地區Id
        /// </summary>
        [Required]
        public int LocationId { get; set; }
    }

    /// <summary>
    /// 取得帳戶列表Response Model
    /// </summary>
    public class GetUsersResponseModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年齡
        /// </summary>
        public int? Age { get; set; }
        /// <summary>
        /// 性別
        /// </summary>
        public string? SexName { get; set; }
        /// <summary>
        /// 所屬省份
        /// </summary>
        public string? ProvinceName { get; set; }
        /// <summary>
        /// 所屬城市(地區)
        /// </summary>
        public string? LocationName { get; set; }
    }
}
