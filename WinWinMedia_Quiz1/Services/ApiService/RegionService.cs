using Azure;
using Microsoft.EntityFrameworkCore;
using UserManagement.DBModels;
using UserManagement.Models;
using UserManagement.Models.General;
using UserManagement.Services.Interface;

namespace UserManagement.Services.ApiService
{
    public class RegionService : IRegionService
    {
        private readonly WinWinDBContext DB;

        public RegionService(WinWinDBContext db)
        {
            DB = db;
        }

        /// <summary>
        /// 取得所有地區
        /// </summary>
        /// <returns></returns>
        public async Task<ResultResponse<List<GetAllLocationsResponseModel>>> GetAllLocations()
        {
            ResultResponse<List<GetAllLocationsResponseModel>> result = new();

            result.Data = await DB.Provinces
                .Select(p => new GetAllLocationsResponseModel
                {
                    Id = p.Id,
                    ProvinceName = p.Name,
                    Locations = p.Locations.Select(l => new Models.Location
                    {
                        Id = l.Id,
                        LocationName = l.Name
                    })
                    .ToList()
                })
                .ToListAsync();

            return result;
        }

        /// <summary>
        /// 取得所有地區男女人數
        /// </summary>
        /// <returns></returns>
        public async Task<ResultResponse<List<GetUserSexsResponseModel>>> GetUserSex()
        {
            ResultResponse<List<GetUserSexsResponseModel>> result = new();

            result.Data = await DB.Locations
               .SelectMany(l => l.Users.GroupBy(u => u.Sex)
               .Select(u => new GetUserSexsResponseModel
               {
                   LocationName = l.Name,
                   SexName = u.Key ? "男" : "女",
                   TotolCount = u.Count()
               }))
               .OrderBy(u => u.LocationName)
               .ThenBy(u => u.SexName)
               .ToListAsync();

            return result;
        }
    }
}
