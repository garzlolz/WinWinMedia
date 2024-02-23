using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TridentTech.Const;
using UserManagement.Models.General;
using UserManagement.Models;
using UserManagement.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("地區相關")]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;

        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        /// <summary>
        /// 取得所有省份以及地區
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK,$"{ResponseMessage.SuccessCode}:{ResponseMessage.Success}",typeof(ResultResponse<List<GetAllLocationsResponseModel>>))]
        public async Task<IActionResult> Get()
        {
            var result = await _regionService.GetAllLocations();
            return StatusCode(result.HttpCode, result);
        }

        /// <summary>
        /// 取得該地區男女人數
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK,$"{ResponseMessage.SuccessCode}:{ResponseMessage.Success}",typeof(ResultResponse<List<GetUserSexsResponseModel>>))]
        [Route("UserSex")]
        public async Task<IActionResult> GetUserSex()
        {
            var result = await _regionService.GetUserSex();
            return StatusCode(result.HttpCode, result);
        }
    }
}
