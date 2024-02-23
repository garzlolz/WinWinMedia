using UserManagement.Models;
using UserManagement.Models.General;

namespace UserManagement.Services.Interface
{
    public interface IUsersService
    {
        /// <summary>
        /// 取得用戶列表
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="MinAge"></param>
        /// <param name="MaxAge"></param>
        /// <param name="Sex"></param>
        /// <returns></returns>
        public Task<ResultResponse<List<GetUsersResponseModel>>> GetUsers(string? Name, int? MinAge, int? MaxAge, bool? Sex);

        /// <summary>
        /// 創建用戶
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public Task<ResultResponse> AddUser(AddUserRequestModel param);
    }
}
