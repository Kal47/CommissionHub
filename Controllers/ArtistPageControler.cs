using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CommissionHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistPageControler : ControllerBase
    {
        private readonly ILogger<ArtistPageControler> _logger;

        [HttpGet]
        public IEnumerable<ArtistModel> Get()
        {
            //database stuff
            throw new NotImplementedException();
            return null;
        }
    }
}
