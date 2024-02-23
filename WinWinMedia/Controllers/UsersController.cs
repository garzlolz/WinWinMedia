using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TridentTech.Const;
using UserManagement.Models;
using UserManagement.Models.General;
using UserManagement.Services.Interface;


namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("用戶相關")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        /// <summary>
        /// 取得使用者列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minAge"></param>
        /// <param name="maxAge"></param>
        /// <param name="sex"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK,$"{ResponseMessage.SuccessCode}:{ResponseMessage.Success}",typeof(ResultResponse<List<GetUsersResponseModel>>))]
        public async Task<IActionResult> Get([FromQuery] string? name, int? minAge, int? maxAge, bool? sex)
        {
            var result = await _usersService.GetUsers(name, minAge, maxAge, sex);
            return StatusCode(result.HttpCode, result);
        }

        /// <summary>
        /// 創建用戶
        /// </summary>
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK,$"{ResponseMessage.SuccessCode}:{ResponseMessage.Success}",typeof(ResultResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, $"{ResponseMessage.AccountIsRegistedCode}:{ResponseMessage.AccountIsRegisted}",typeof(ResultResponse))]
        public async Task<IActionResult> AddUser([FromBody] AddUserRequestModel param)
        {
            var result = await _usersService.AddUser(param);
            return StatusCode(result.HttpCode, result);
        }
    }
}
