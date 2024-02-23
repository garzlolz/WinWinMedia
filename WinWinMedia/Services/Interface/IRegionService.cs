using Azure;
using UserManagement.Models;
using UserManagement.Models.General;

namespace UserManagement.Services.Interface
{
    public interface IRegionService
    {
        public Task<ResultResponse<List<GetAllLocationsResponseModel>>> GetAllLocations();
        /// <summary>
        /// 取得該地區男女人數
        /// </summary>
        /// <returns></returns>
        public Task<ResultResponse<List<GetUserSexsResponseModel>>> GetUserSex();
    }
}
