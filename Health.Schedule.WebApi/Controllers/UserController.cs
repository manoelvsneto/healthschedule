using Health.Schedule.Service;
using Health.Schedule.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Health.Schedule.WebApi.Controllers
{
    /// <summary>
    /// UserController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// IUserService
        /// </summary>
        public IUserService userService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public UserController(IUserService service)
        {
            userService = service;
        }

        // POST api/values
        /// <summary>
        /// POST api/user
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DataReturn> Post([FromBody] User value)
        {
            return await userService.Add(value);
        }

        /// <summary>
        /// Validate
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Validate/{query}")]
        public async Task<DataReturn> Validate(string query)
        {
            return await userService.Validate(query);
        }
    }
}
