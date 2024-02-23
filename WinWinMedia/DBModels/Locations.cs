using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.DBModels
{
    /// <summary>
    /// 地區 Table
    /// </summary>
    [Table("locations")]
    public class Location
    {
        /// <summary>
        /// 地區 Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("location_id")]
        public int Id { get; set; }
        /// <summary>
        /// 地區名稱
        /// </summary>
        [Column("location_name")]
        public required string Name { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        [Column("location_province_id")]
        public int? ProvinceId { get; set; }
        /// <summary>
        /// 所屬省份
        /// </summary>
        public Province? Province { get; set; }
        /// <summary>
        /// 所屬用戶
        /// </summary>
        public ICollection<User>? Users { get; set; }
    }
}
