namespace UserManagement.Models
{
    /// <summary>
    /// 取得所有省份以及地區
    /// </summary>
    public class GetAllLocationsResponseModel
    {
        /// <summary>
        /// 省份Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 省份名稱
        /// </summary>
        public string ProvinceName { get; set; }
        /// <summary>
        /// 該省份低區列表
        /// </summary>
        public List<Location>? Locations { get; set; }
    }

    /// <summary>
    /// 地區
    /// </summary>
    public class Location
    {
        /// <summary>
        /// 地區Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 地區名稱
        /// </summary>
        public string? LocationName { get; set; }
    }

    /// <summary>
    /// 取得該地區男女人數 ResponseModel
    /// </summary>
    public class GetUserSexsResponseModel
    {
        /// <summary>
        /// 地區名稱
        /// </summary>
        public string? LocationName { get; set; }
        /// <summary>
        /// 性別
        /// </summary>
        public string? SexName { get; set; }
        /// <summary>
        /// 該地區總人數
        /// </summary>
        public int? TotolCount { get; set; }
    }
}
