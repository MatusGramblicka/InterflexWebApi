using InterflexWebApi.DTO;
using InterflexWebApi.Interfaces;
using InterflexWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterflexWebApi.Controllers
{
    [Route("interflex")]
    [ApiController]
    public class InterflexController :  ControllerBase
    {
        private readonly IInterflexLib _interflexLib;

        public InterflexController(IInterflexLib interflexLib)
        {
            _interflexLib = interflexLib;
        }

        [HttpPost]
        public async Task<ActionResult<List<DayAndTime>>> GetInterflexData([FromBody] CredentialsInteflex credentials)
        {
            if (credentials.User.Length <= 0 || credentials.Password.Length <= 0) 
                return BadRequest();

            var listActualTimes = await _interflexLib.GetInterflexData(credentials.User, credentials.Password);

            return Ok(listActualTimes);
        }
    }
}