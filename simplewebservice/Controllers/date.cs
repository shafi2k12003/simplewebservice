using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace simplewebservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class date : ControllerBase
    {
        private readonly ILogger<date> _logger;

        public date(ILogger<date> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            string dateTime = DateTime.Now.ToString("ddd dd MMM yyy HH:mm:ss BST yyy");
            return Ok(new {date=dateTime, });


        }
    }
}
