using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.DBModels
{
    /// <summary>
    /// 省份
    /// </summary>
    [Table("provinces")]
    public class Province
    {
        /// <summary>
        /// 省份 Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("province_id")]
        public int Id { get; set; }
        /// <summary>
        /// 省份名稱
        /// </summary>
        [Column("province_name")]
        [StringLength(20)]
        public required string Name { get; set; }
        /// <summary>
        /// 該省份所有城市
        /// </summary>
        public ICollection<Location>? Locations { get; set; }
    }
}
