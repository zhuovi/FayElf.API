using FayElf.Models.Entity;
using FayElf.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XiaoFeng;

namespace FayElf.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IDbContext _dbContext;
        public HomeController(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("City")]
        public List<City> City()
        {
            return _dbContext.Query<City>().Skip(0).Take(50).ToList();
        }
        [HttpGet("Area")]
        public List<Area> Area()
        {
            return _dbContext.Query<Area>().Skip(0).Take(50).ToList();
        }
        [HttpGet("Province")]
        public List<Province> Province()
        {
            return _dbContext.Query<Province>().Skip(0).Take(50).ToList();
        }
        [HttpGet("UserInfo")]
        public List<UserInfoView> UserInfo()
        {
            return _dbContext.Query<UserInfo>().ToList<UserInfoView>();
        }
    }
}
