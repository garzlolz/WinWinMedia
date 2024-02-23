using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TridentTech.Const;
using UserManagement.DBModels;
using UserManagement.Models;
using UserManagement.Models.General;
using UserManagement.Services.Interface;

namespace UserManagement.Services.ApiService
{
    public class UsersService : IUsersService
    {
        private readonly WinWinDBContext DB;

        public UsersService(WinWinDBContext db)
        {
            DB = db;
        }

        /// <summary>
        /// 取得用戶列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minAge"></param>
        /// <param name="maxAge"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        public async Task<ResultResponse<List<GetUsersResponseModel>>> GetUsers(string? name, int? minAge, int? maxAge, bool? sex)
        {
            ResultResponse<List<GetUsersResponseModel>> result = new();

            result.Data = await DB.Users.Where(u =>
                    (name.IsNullOrEmpty() || u.Name.Contains(name))
                    || (!minAge.HasValue || u.Age >= minAge)
                    || (!maxAge.HasValue || u.Age <= maxAge)
                    || (!sex.HasValue || u.Sex == sex))
                .Select(u => new GetUsersResponseModel
                {
                    Id = u.Id,
                    Name = u.Name,
                    Age = u.Age,
                    SexName = u.Sex ? "男" : "女",
                    ProvinceName = u.Location.Province.Name,
                    LocationName = u.Location.Name
                })
                .ToListAsync();

            if (result.Data == null)
            {
                result.Code = ResponseMessage.DataNotFoundCode;
                result.Message = ResponseMessage.DataNotFound;
                return result;
            }

            return result;
        }

        /// <summary>
        /// 創建用戶
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<ResultResponse> AddUser(AddUserRequestModel param)
        {
            ResultResponse result = new();
            var isEmailExist = await DB.Users.AnyAsync(u => u.Email == param.Email);

            if (isEmailExist)
            {
                result.HttpCode = StatusCodes.Status400BadRequest;
                result.Code = ResponseMessage.AccountIsRegistedCode;
                result.Code = ResponseMessage.AccountIsRegisted;
                return result;
            }

            User user = new()
            {
                Email = param.Email,
                Name = param.Name,
                Age = param.Age,
                LocationId = param.LocationId,
                PassWord = param.Password,
                Sex = param.Sex
            };

            await DB.Users.AddAsync(user);
            await DB.SaveChangesAsync();

            return result;
        }
    }
}
