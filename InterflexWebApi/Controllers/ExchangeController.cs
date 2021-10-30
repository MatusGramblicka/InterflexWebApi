using InterflexWebApi.DTO;
using InterflexWebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterflexWebApi.Controllers
{
    [Route("exchange")]
    [ApiController]
    public class ExchangeController : ControllerBase
    {
        private readonly IExchangeLib _exchangeLib;

        public ExchangeController(IExchangeLib exchangeLib)
        {
            _exchangeLib = exchangeLib;
        }

        [HttpPost]
        public async Task<ActionResult<(List<Exchange>,bool)>> GetExchangeData([FromBody] CredentialsExchange credentials)
        {
            if (credentials.User.Length <= 0 || credentials.Password.Length <= 0)
                return BadRequest();

            var appointments = new List<Exchange>();
            var success = false;

            (appointments, success) = await _exchangeLib.GetExchangeData(credentials.User, credentials.Password);

            return Ok(appointments);
        }

    }
}